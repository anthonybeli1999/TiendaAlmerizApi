using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Colores.Queries
{
    public class ObtenerColoresQueryHandler : IRequestHandler<ObtenerColoresQuery,
        IEnumerable<DtoColores>>
    {

        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        
        public ObtenerColoresQueryHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }
        

        public async Task<IEnumerable<DtoColores>> Handle(ObtenerColoresQuery request,
            CancellationToken cancellationToken)
        {
            var colores = _repositorioOperacionGeneral
                .Listar<Color>().ToList();
            return colores
                .ConvertAll(c => ColorMap.MapearEntidadADto(c));
        }
    }
}
