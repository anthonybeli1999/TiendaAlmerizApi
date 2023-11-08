using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Aplicacion.Features.Valoracion.Queries;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Valoracion.Queries
{
    public class ObtenerValoracionesQueryHandler : IRequestHandler<ObtenerValoracionesQuery,
       IEnumerable<DtoValoracion>>
    {

        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;


        public ObtenerValoracionesQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }


        public async Task<IEnumerable<DtoValoracion>> Handle(ObtenerValoracionesQuery request,
            CancellationToken cancellationToken)
        {
            var valoraciones = _repositorioOperacionGeneral
                .Listar<Valoraciones>().ToList();
            return valoraciones
                .ConvertAll(m => ValoracionMap.MapearEntidadADto(m));
        }


    }
}
