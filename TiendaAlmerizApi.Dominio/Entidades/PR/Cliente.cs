using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Entidades.PR
{
    /// <summary>
    /// Clase que representa la entidad colores
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Id del color
        /// </summary>
        public int IdCliente { get; private set; }

        /// <summary>
        /// Descripcion del color
        /// </summary>
        public string NombreCliente { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string ApellidoCliente { get; private set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        /// 
        public int DniCliente { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string DireccionenvioCliente { get; private set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        ///  public string NombreCliente { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string EmailCliente { get; private set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        public string ContraseñaCliente { get; private set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        ///  public string NombreCliente { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public int CelularCliente { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get; private set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        public DateTime FechaRegistro { get; private set; }

        /// <summary>
        /// Usuario registro
        /// </summary>
        public string UsuarioRegistro { get; private set; }

        /// <summary>
        /// Fecha modificacion
        /// </summary>
        public DateTime FechaModificacion { get; private set; }

        /// <summary>
        /// Usuario modificacion
        /// </summary>
        public string UsuarioModificacion { get; private set; }

        public static Cliente Crear(string nombreCliente,string apellidoCliente, int dniCliente, string direccionenvioCliente,
            string emailCliente, string contraseñaCliente, int celularCliente, string usuarioRegistro)
        {
            return new Cliente
            {
                NombreCliente = nombreCliente,
                ApellidoCliente = apellidoCliente,
                DniCliente = dniCliente,
                DireccionenvioCliente = direccionenvioCliente,
                EmailCliente = emailCliente,
                ContraseñaCliente = contraseñaCliente,
                CelularCliente = celularCliente,
                IndicadorEstado = "A",
                UsuarioRegistro = usuarioRegistro,
                UsuarioModificacion = usuarioRegistro,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }

        public void InactivarColor()
        {
            IndicadorEstado = "I";
            FechaModificacion = DateTime.Now;
            UsuarioModificacion = "RBELIZARIO";
        }
    }
}
