using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Datos.Interfaces;

namespace TiendaAlmerizApi.Datos.Contextos
{
    public class ContextoBaseSaf<TContexto> : DbContext, IContextoBase where TContexto : class
    {
        private readonly DbContextOptions<ContextoGeneralSaf> _options;


        /// <summary>
        /// Constructor estatico, establece la inicialización de los elementos de la base de datos.
        /// </summary>
        public ContextoBaseSaf
            (DbContextOptions<ContextoGeneralSaf> options) 
            : base(options)
        {
            _options = options;
        }


        /// <summary>
        /// Configuracion de la cadena de conexion
        /// </summary>
        /// <param name="optionsBuilder">DbContextOptionsBuilder</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(ObtenerCadenaConexion()).UseLazyLoadingProxies();
        }

        /// <summary>
        /// Método para establecer la conexion con la base de datos
        /// </summary>
        /// <returns>Datos de la conexion</returns>
        private static string ObtenerCadenaConexion()
        {
            string servidor = "DESKTOP-E552047\\SQLEXPRESS";
            string catalogo = "db_almeriz";

            var datosConexion = new SqlConnectionStringBuilder
            {
                DataSource = servidor,
                InitialCatalog = catalogo,
                IntegratedSecurity = true,
                ApplicationName = "TiendaAlmerizApi"
            };
            return datosConexion.ConnectionString;
        }


        /// <summary>
        /// Método que obtiene el conjunto de datos de una entidad.
        /// </summary>
        /// <typeparam name="T">Tipo de conjunto.</typeparam>
        /// <returns>Conjunto de datos de una entidad</returns>
        public DbSet<T> Establecer<T>() where T : class
        {
            return Set<T>();
        }

        /// <summary>
        /// Método para guardar los cambios a la base de datos.
        /// </summary>
        public void GuardarCambios()
        {
            try
            {
                SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entidadesInvolucradas = ex.Entries.Aggregate(string.Empty,
                    (current, entidad) => current + (entidad.Entity.GetType() + ","));

                throw new Exception("Error al guardar cambios en BBDD. Problemas de concurrencia.", ex);
            }
            catch (DbUpdateException ex)
            {
                var mensaje = ex.Entries.Aggregate(string.Empty,
                    (current, entidad) => current + ("Entidad de tipo " + entidad.Entity.GetType().Name +
                                                     " en estado " + entidad.State +
                                                     " tiene los siguientes errores de validación: "));

                throw new Exception("Error al guardar cambios en BBDD. " + mensaje, ex);
            }
        }
    }
}
