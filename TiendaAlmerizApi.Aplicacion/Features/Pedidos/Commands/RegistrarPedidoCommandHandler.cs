using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Pedidos.Commands
{
    public class RegistrarPedidoCommandHandler : IRequestHandler<RegistrarPedidoCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public RegistrarPedidoCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(RegistrarPedidoCommand request,
            CancellationToken cancellationToken)
        {
            var pedido = Pedido.Crear(request.Cantidad,request.MontoTtotal,request.MetodoPago,request.IdCliente,
                request.UsuarioRegistro);

            var nuevoPedido = await _repositorioOperacionGeneral
                .AdicionarAsync(pedido);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoPedido.IdPedido;
        }
    }
}
