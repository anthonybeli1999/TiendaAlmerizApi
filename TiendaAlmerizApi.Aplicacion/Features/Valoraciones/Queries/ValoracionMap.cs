using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Valoraciones.Queries
{
    /// <summary>
    /// Clase static de las subcategorias
    /// </summary>
    public static class ValoracionMap
    {
        /// <summary>
        /// Metodo de mapeo de entidad a dto
        /// </summary>
        /// <param name="agencia">Entidad Agencia</param>
        /// <returns>AgenciaVm</returns>
        public static DtoValoracion MapearEntidadADto(Valoracion valoracion)
        {
            return new DtoValoracion
            {
                IdValoracion = valoracion.IdValoracion,
                Comentario = valoracion.Comentario,
                Puntaje = valoracion.Puntaje,
                IndicadorEstado = valoracion.IndicadorEstado,
                IdCliente = valoracion.IdCliente,
                FechaRegistro = valoracion.FechaRegistro,
                UsuarioRegistro = valoracion.UsuarioRegistro
            };
        }
    }
}