using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Dtos.PR
{
    public class DtoCliente
    {
        public int IdCliente { get;  set; }

        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string NombreCliente { get;  set; }

        /// <summary>
        /// Apellido del cliente
        /// </summary>
        public string ApellidoCliente { get;  set; }

        /// <summary>
        /// DNI de cliente
        /// </summary>
        /// 
        public int DniCliente { get;  set; }

        /// <summary>
        /// Direccion de envio del cliente
        /// </summary>
        public string DireccionenvioCliente { get;  set; }

        /// <summary>
        /// Email del cliente
        /// </summary>
        

        public string EmailCliente { get;  set; }

        /// <summary>
        /// Contraseña cliente
        /// </summary>
        
        public string ContraseñaCliente { get;  set; }

        /// <summary>
        /// Celular cliente
        /// </summary>

        
        public int CelularCliente { get;  set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get;  set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        public DateTime FechaRegistro { get;  set; }

        /// <summary>
        /// Usuario registro
        /// </summary>
        public string UsuarioRegistro { get;  set; }

      
    }
}
