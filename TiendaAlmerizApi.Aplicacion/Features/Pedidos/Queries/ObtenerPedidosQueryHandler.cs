using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Aplicacion.Features.Materiales.Queries;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Pedidos.Queries
{
    public class ObtenerPedidosQueryHandler : IRequestHandler<ObtenerPedidosQuery,
     IEnumerable<DtoPedido>>
    {

        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;


        public ObtenerPedidosQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }


        public async Task<IEnumerable<DtoPedido>> Handle(ObtenerPedidosQuery request,
            CancellationToken cancellationToken)
        {
            var pedido = _repositorioOperacionGeneral
                .Listar<Pedido>().ToList();
            return pedido
                .ConvertAll(m => PedidoMap.MapearEntidadADto(m));
        }
    }
}