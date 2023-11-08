using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Aplicacion.Features.Categorias.Queries;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Clientes.Queries
{
    public class ObtenerClientesQueryHandler : IRequestHandler<ObtenerClientesQuery,
     IEnumerable<DtoCliente>>
    {

        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;


        public ObtenerClientesQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }


        public async Task<IEnumerable<DtoCliente>> Handle(ObtenerClientesQuery request,
            CancellationToken cancellationToken)
        {
            var clientes = _repositorioOperacionGeneral
                .Listar<Cliente>().ToList();
            return clientes
                .ConvertAll(c => ClienteMap.MapearEntidadADto(c));
        }


    }
}
