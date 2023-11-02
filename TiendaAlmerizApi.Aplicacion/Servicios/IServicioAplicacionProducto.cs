using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;

namespace TiendaAlmerizApi.Aplicacion.Servicios
{
    public interface IServicioAplicacionProducto : IServicioBase
    {
        #region Consultas
        public DtoColores ObtenerColores();

        public object ObtenerMateriales();

        #endregion Consultas


        #region Operaciones

        #endregion Operaciones


        #region Validaciones

        #endregion Validaciones
    }
}
