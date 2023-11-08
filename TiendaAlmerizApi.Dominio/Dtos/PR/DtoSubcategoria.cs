using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Dtos.PR
{
    public class DtoSubcategoria
    {
        /// <summary>
        /// Id de subcategoria
        /// </summary>
        public int IdSubcategoria { get; set; }

        /// <summary>
        /// Descripcion de subcategoria
        /// </summary>
        public string DescripcionSubcategoria { get; set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get; set; }


        /// <summary>
        /// Id de categoria
        /// </summary>
        public int IdCategoria { get; set; }

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
