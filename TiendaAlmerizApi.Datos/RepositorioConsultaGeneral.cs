using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Excepciones;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Datos.Contextos;

namespace TiendaAlmerizApi.Datos
{
    public class RepositorioConsultaGeneral : IRepositorioOperacionGeneral
    {
        protected readonly ContextoGeneralSaf _contextoConsultas;

        public RepositorioConsultaGeneral(ContextoGeneralSaf contextoConsultas)
        {
            _contextoConsultas = contextoConsultas;
        }

        public T ObtenerPorCodigo<T>(params object[] ao_llaves) where T : class
        {
            var entidad = _contextoConsultas.Establecer<T>().Find(ao_llaves);

            if (entidad == null)
            {
                throw new EntidadNoExisteException(typeof(T), ao_llaves);
            }

            return entidad;
        }

        public T ObtenerUnoONulo<T>(Expression<Func<T, bool>> filtro,
            string incluir = null) where T : class
        {
            try
            {
                return _contextoConsultas.Establecer<T>().FirstOrDefault(filtro);
            }
            catch (Exception excepcion)
            {
                throw new InvalidOperationException(excepcion.Message);
            }
        }

        public IList<T> ObtenerPorExpresionConLimite<T>(Expression<Func<T, bool>> ao_filtro = null,
            string as_incluir = null,
            byte aby_limite = 0) where T : class
        {
            try
            {
                if (ao_filtro != null)
                {
                    if (aby_limite == 0)
                        return _contextoConsultas.Establecer<T>().Where(ao_filtro).ToList();
                    else
                        return _contextoConsultas.Establecer<T>().Where(ao_filtro).Take(aby_limite).ToList();
                }
                else
                {
                    return _contextoConsultas.Establecer<T>().ToList();
                }
            }
            catch (Exception le_excepcion)
            {
                throw new EntidadNoExisteException(typeof(T), "Error BD: " + le_excepcion);
            }
        }

        public IQueryable<T> Listar<T>() where T : class
        {
            return _contextoConsultas
                .Establecer<T>();
        }

        public async Task<IReadOnlyList<T>> ObtenerTodoAsync<T>() where T : class
        {
            return await _contextoConsultas
                .Set<T>()
                .ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ObtenerAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return await _contextoConsultas
                .Set<T>()
                .Where(predicate)
                .ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ObtenerAsync<T>(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includeString = null,
            bool disableTracking = true) where T : class
        {
            IQueryable<T> query = _contextoConsultas.Set<T>();

            if (disableTracking) query = query.AsNoTracking();

            if (string.IsNullOrEmpty(includeString)) query = query.Include(includeString);

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            return await query.ToListAsync();
        }

        public async Task<IReadOnlyList<T>> ObtenerAsync<T>(Expression<Func<T, bool>> predicate = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            List<Expression<Func<T, object>>> includes = null,
            bool disableTracking = true) where T : class
        {
            IQueryable<T> query = _contextoConsultas
                .Set<T>();

            if (disableTracking) query = query.AsNoTracking();

            if (includes != null) query = includes.Aggregate(query, (current, include) => current.Include(include));

            if (predicate != null) query = query.Where(predicate);

            if (orderBy != null)
                return await orderBy(query).ToListAsync();

            return await query.ToListAsync();
        }

        public virtual async Task<T> ObtenerPorIdAsync<T>(int id) where T : class
        {
            return await _contextoConsultas
                .Set<T>()
                .FindAsync(id);
        }

        public async Task<T> AdicionarAsync<T>(T entity) where T : class
        {
            try
            {
                _contextoConsultas
                .Set<T>()
                .Add(entity);
                return entity;
            }
            catch (Exception le_excepcion)
            {
                throw new EntidadNoExisteException(typeof(T), "Error BD: " + le_excepcion);
            }
        }

        public async Task<T> ModificarAsync<T>(T aoObjeto) where T : class
        {
            _contextoConsultas.Entry(aoObjeto).State = EntityState.Modified;
            await _contextoConsultas
                .SaveChangesAsync();
            return aoObjeto;
        }

        public async Task EliminarAsync<T>(T aoObjeto) where T : class
        {
            _contextoConsultas
                .Set<T>()
                .Remove(aoObjeto);
            await _contextoConsultas
                .SaveChangesAsync();
        }

        public void GuardarCambios()
        {
            try
            {
                _contextoConsultas.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw new ValidacionException("Error al guardar cambios en bbdd. " + e.Message);
            }
        }
    }
}
