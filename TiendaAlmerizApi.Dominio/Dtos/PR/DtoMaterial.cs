using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Dtos.PR
{
    /// <summary>
    /// Clase que representa los colores
    /// </summary>
    public class DtoMaterial
    {
        /// <summary>
        /// Id del material
        /// </summary>
        public int IdMaterial { get; set; }

        /// <summary>
        /// Descripcion del material
        /// </summary>
        public string DescripcionMaterial { get; set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get; set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        public DateTime FechaRegistro { get; set; }

        /// <summary>
        /// Usuario registro
        /// </summary>
        public string UsuarioRegistro { get; set; }
    }
}
