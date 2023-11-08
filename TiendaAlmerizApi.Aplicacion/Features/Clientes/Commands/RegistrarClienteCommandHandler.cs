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
    public class RegistrarClienteCommandHandler : IRequestHandler<RegistrarClienteCommand, int>
    {
        private readonly IRepositorioOperacionGeneral _repositorioOperacionGeneral;

        public RegistrarClienteCommandHandler(IRepositorioOperacionGeneral repositorioOperacionGeneral)
            : base()
        {
            _repositorioOperacionGeneral = repositorioOperacionGeneral;
        }

        public async Task<int> Handle(RegistrarClienteCommand request,
            CancellationToken cancellationToken)
        {
            var cliente = Cliente.Crear(request.NombreCliente,request.ApellidoCliente,request.DniCliente,request.DireccionenvioCliente,
                request.EmailCliente, request.ContraseñaCliente,request.CelularCliente,
                request.UsuarioRegistro);

            var nuevoCliente = await _repositorioOperacionGeneral
                .AdicionarAsync(cliente);
            _repositorioOperacionGeneral.GuardarCambios();

            return nuevoCliente.IdCliente;
        }
    }
}