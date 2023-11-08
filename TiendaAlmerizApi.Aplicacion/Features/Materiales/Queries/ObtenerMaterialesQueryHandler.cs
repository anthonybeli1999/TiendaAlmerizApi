using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Aplicacion.Features.Colores.Queries;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Materiales.Queries
{
    public class ObtenerMaterialesQueryHandler : IRequestHandler<ObtenerMaterialesQuery,
       IEnumerable<DtoMaterial>>
    {

        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;


        public ObtenerMaterialesQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }


        public async Task<IEnumerable<DtoMaterial>> Handle(ObtenerMaterialesQuery request,
            CancellationToken cancellationToken)
        {
            var materiales = _repositorioOperacionGeneral
                .Listar<Material>().ToList();
            return materiales
                .ConvertAll(m => MaterialMap.MapearEntidadADto(m));
        }
    }
}