using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Categorias.Queries
{
    /// <summary>
    /// Clase static de los colores
    /// </summary>
    public static class CategoriaMap
    {
        /// <summary>
        /// Metodo de mapeo de entidad a dto
        /// </summary>
        /// <param name="agencia">Entidad Agencia</param>
        /// <returns>AgenciaVm</returns>
        public static DtoCategoria MapearEntidadADto(Categoria categoria)
        {
            return new DtoCategoria
            {
                IdCategoria = categoria.IdCategoria,
                DescripcionCategoria = categoria.DescripcionCategoria,
                IndicadorEstado = categoria.IndicadorEstado,
                FechaRegistro = categoria.FechaRegistro,
                UsuarioRegistro = categoria.UsuarioRegistro
            };
        }
    }
}
