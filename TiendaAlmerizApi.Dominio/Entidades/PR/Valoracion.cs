using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Entidades.PR
{
    /// <summary>
    /// Clase que representa la entidad valoracion
    /// </summary>
    public class Valoracion
    {
        /// <summary>
        /// Id de la valoracion
        /// </summary>
        public int IdValoracion { get; private set; }

        /// <summary>
        /// Comnetario del cliente
        /// </summary>
        public string Comentario { get; private set; }

        /// <summary>
        /// Puntaje
        /// </summary>
        public int Puntaje { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get; private set; }

        /// <summary>
        /// Id del cliente
        /// </summary>
        public int IdCliente { get; private set; }

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

        public static Valoracion Crear(string Comentario,int Puntaje, int IdCliente,
            string usuarioRegistro)
        {
            return new Valoracion
            {
                Comentario = Comentario,
                Puntaje = Puntaje,
                IdCliente = IdCliente,
                IndicadorEstado = "A",
                UsuarioRegistro = usuarioRegistro,
                UsuarioModificacion = usuarioRegistro,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }

        public void InactivarValoracion()
        {
            IndicadorEstado = "I";
            FechaModificacion = DateTime.Now;
            UsuarioModificacion = "RBELIZARIO";
        }
    }
}
