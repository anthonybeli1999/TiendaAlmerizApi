using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Utilidades.Error;

namespace TiendaAlmerizApi.Core.Utilidades
{
    public class Response<T>
    {
        /// <summary>
        /// Resultado de la operacion
        /// </summary>
        public bool Resultado { get; set; }
        /// <summary>
        /// Codigo de error
        /// </summary>
        public string CodigoError { get; set; }
        /// <summary>
        /// Estado del codigo
        /// </summary>
        public int StatusCode { get; set; }
        /// <summary>
        /// Datos de la operacion
        /// </summary>
        public object? Datos { get; set; }

        /// <summary>
        /// CodeErrorException
        /// </summary>
        public CodeErrorException Errores { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Response()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dato">Objeto dato</param>
        public Response(object? dato)
        {
            this.Resultado = true;
            this.Datos = dato ?? string.Empty;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="codigoError">Codigo de error</param>
        /// <param name="statusCode">Estado del codigo</param>
        /// <param name="errores">Errores en CodeErrorException</param>
        public Response(string codigoError, int statusCode,
            CodeErrorException errores)
        {
            this.Resultado = false;
            this.CodigoError = codigoError;
            this.StatusCode = statusCode;
            this.Errores = errores;
        }
    }
}
