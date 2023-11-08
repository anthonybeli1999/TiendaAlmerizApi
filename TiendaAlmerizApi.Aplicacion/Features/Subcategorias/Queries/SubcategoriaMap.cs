using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Subcategorias.Queries
{
    /// <summary>
    /// Clase static de las subcategorias
    /// </summary>
    public static class SubcategoriaMap
    {
        /// <summary>
        /// Metodo de mapeo de entidad a dto
        /// </summary>
        /// <param name="agencia">Entidad Agencia</param>
        /// <returns>AgenciaVm</returns>
        public static DtoSubcategoria MapearEntidadADto(Subcategoria subcategoria)
        {
            return new DtoSubcategoria
            {
                IdSubcategoria = subcategoria.IdSubcategoria,
                DescripcionSubcategoria = subcategoria.DescripcionSubcategoria,
                IndicadorEstado = subcategoria.IndicadorEstado,
                IdCategoria = subcategoria.IdCategoria,
                FechaRegistro = subcategoria.FechaRegistro,
                UsuarioRegistro = subcategoria.UsuarioRegistro
            };
        }
    }
}