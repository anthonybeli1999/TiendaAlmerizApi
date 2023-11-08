using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Aplicacion.Features.Colores.Commands;
using TiendaAlmerizApi.Core.Repositorios;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Clientes.Commands
{
    public class ModificarEstadoClienteCommandHandler : IRequestHandler<ModificarEstadoClienteCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public ModificarEstadoClienteCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(ModificarEstadoClienteCommand request,
            CancellationToken cancellationToken)
        {
            var cliente = _repositorioOperacionGeneral
                .ObtenerPorCodigo<Cliente>(request.IdCliente);

            cliente.InactivarColor();
            _repositorioOperacionGeneral.GuardarCambios();

            return cliente.IdCliente;
        }
    }
}
