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
    public class ModificarEstadoPedidoCommandHandler : IRequestHandler<ModificarEstadoPedidoCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarEstadoPedidoCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(ModificarEstadoPedidoCommand request,
            CancellationToken cancellationToken)
        {
            var pedido = _repositorioOperacionGeneral
                .ObtenerPorCodigo<Pedido>(request.IdPedido);

            pedido.InactivarPedido();
            _repositorioOperacionGeneral.GuardarCambios();

            return pedido.IdPedido;
        }
    }
}
