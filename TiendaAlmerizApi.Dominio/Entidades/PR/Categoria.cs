using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Entidades.PR
{
    /// <summary>
    /// Clase que representa la entidad categorias
    /// </summary>
    public class Categoria
    {
        /// <summary>
        /// Id de la categoria
        /// </summary>
        public int IdCategoria { get; private set; }

        /// <summary>
        /// Descripcion de categoria
        /// </summary>
        public string DescripcionCategoria { get; private set; }

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

        public static Categoria Crear(string descripcionCategoria,
            string usuarioRegistro)
        {
            return new Categoria
            {
                DescripcionCategoria = descripcionCategoria,
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
