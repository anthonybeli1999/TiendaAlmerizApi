using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Colores.Queries
{
    /// <summary>
    /// Clase static de los colores
    /// </summary>
    public static class ColorMap
    {
        /// <summary>
        /// Metodo de mapeo de entidad a dto
        /// </summary>
        /// <param name="agencia">Entidad Agencia</param>
        /// <returns>AgenciaVm</returns>
        public static DtoColores MapearEntidadADto(Color color)
        {
            return new DtoColores
            {
                IdColor = color.IdColor,
                DescripcionColor = color.DescripcionColor,
                IndicadorEstado = color.IndicadorEstado,
                FechaRegistro = color.FechaRegistro,
                UsuarioRegistro = color.UsuarioRegistro
            };
        }
    }
}
