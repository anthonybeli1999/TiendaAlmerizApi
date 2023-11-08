using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Materiales.Queries
{
    /// <summary>
    /// Clase static de los materiales
    /// </summary>
    public static class MaterialMap
    {
        /// <summary>
        /// Metodo de mapeo de entidad a dto
        /// </summary>
        /// <param name="agencia">Entidad Agencia</param>
        /// <returns>AgenciaVm</returns>
        public static DtoMaterial MapearEntidadADto(Material material)
        {
            return new DtoMaterial
            {
                IdMaterial = material.IdMaterial,
                DescripcionMaterial = material.DescripcionMaterial,
                IndicadorEstado = material.IndicadorEstado,
                FechaRegistro = material.FechaRegistro,
                UsuarioRegistro = material.UsuarioRegistro
            };
        }
    }
}
