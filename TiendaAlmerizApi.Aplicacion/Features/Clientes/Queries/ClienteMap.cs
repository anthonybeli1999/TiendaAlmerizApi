using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Dtos.PR;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Aplicacion.Features.Clientes.Queries
{
    public static class ClienteMap
    {
        /// <summary>
        /// Metodo de mapeo de entidad a dto
        /// </summary>
        /// <param name="agencia">Entidad Agencia</param>
        /// <returns>AgenciaVm</returns>
        public static DtoCliente MapearEntidadADto(Cliente cliente)
        {
            return new DtoCliente
            {
                IdCliente = cliente.IdCliente,
                NombreCliente = cliente.NombreCliente,
                ApellidoCliente = cliente.ApellidoCliente,
                DniCliente = cliente.DniCliente,
                DireccionenvioCliente = cliente.DireccionenvioCliente,
                EmailCliente = cliente.EmailCliente,
                ContraseñaCliente = cliente.ContraseñaCliente,
                CelularCliente = cliente.CelularCliente,
                IndicadorEstado = cliente.IndicadorEstado,
                FechaRegistro = cliente.FechaRegistro,
                UsuarioRegistro = cliente.UsuarioRegistro
            };
        }
    }
}