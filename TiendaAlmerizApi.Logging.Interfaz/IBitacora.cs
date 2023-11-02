using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Logging.Interfaz
{
    public interface IBitacora<T> where T : class
    {
        /// <summary>
        /// Bitacora muy detallada, puede generar alto volumen de información.
        /// </summary>
        /// <param name="mensaje">Mensaje a bitacorizar.</param>
        void Trace(string mensaje);
    }
}
