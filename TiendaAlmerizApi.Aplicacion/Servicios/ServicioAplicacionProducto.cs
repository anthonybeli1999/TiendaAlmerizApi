using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;

namespace TiendaAlmerizApi.Aplicacion.Servicios
{
    public class ServicioAplicacionProducto : IServicioAplicacionProducto
    {
        #region Consultas
        public DtoColores ObtenerColores()
        {
            return new DtoColores();
        }

        public object ObtenerMateriales()
        {
            throw new NotImplementedException();
        }

        #endregion Consultas


        #region Operaciones

        #endregion Operaciones


        #region Validaciones

        #endregion Validaciones
    }
}
