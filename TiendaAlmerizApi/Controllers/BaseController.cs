
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using TiendaAlmerizApi.Core.Utilidades;
using TiendaAlmerizApi.Core.Utilidades.Error;
using TiendaAlmerizApi.Logging.Interfaz;

namespace TiendaAlmerizApi.Controllers
{
    public class BaseController<T> : ControllerBase where T : class
    {
        //protected IBitacora<T> _bitacora { get; }
        protected IMediator _mediator;

        protected BaseController(//IBitacora<T> bitacora,
            IMediator mediator)
        {
            //_bitacora = bitacora;
            _mediator = mediator;
        }
        public async Task<Response<T>> OperationMediator<T>(T operacion) where T : class
        {
            try
            {
                var respuesta = await _mediator.Send(operacion);
                return new Response<T>(respuesta);
            }
            catch (Exception excepcion)
            {
                var statusCode = (int)HttpStatusCode.InternalServerError;
                var codigoError = string.Empty;
                var resultado = string.Empty;

                Exception(excepcion);

                if (string.IsNullOrEmpty(resultado))
                {
                    return new Response<T>(codigoError, statusCode, new CodeErrorException
                        (codigoError, excepcion.Message));
                }

                return new Response<T>(codigoError, statusCode, new CodeErrorException
                    (codigoError, resultado));
            }
        }

        private void Exception(Exception exception)
        {
            var excepcionInicial = ObtenerExcepcionInicial(exception);
            var stack = new StackTrace(exception);
            var metodoOrigen = stack.GetFrames().Select(stakFrame => stakFrame?.GetMethod()).First();
        }

        private static Exception ObtenerExcepcionInicial(Exception excepcion)
        {
            var excepcionInicial = excepcion;
            var contador = 1000;

            while (contador > 0)
            {
                var excepcionAnterior = excepcionInicial.InnerException;
                if (excepcionAnterior == null)
                {
                    break;
                }

                excepcionInicial = excepcionAnterior;
                contador--;
            }

            return excepcionInicial;
        }
    }
}
