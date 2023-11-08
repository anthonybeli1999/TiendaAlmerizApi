using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Entidades.PR
{
    /// <summary>
    /// Clase que representa la entidad material
    /// </summary>
    public class Material
    {
        /// <summary>
        /// Id del color
        /// </summary>
        public int IdMaterial { get; private set; }

        /// <summary>
        /// Descripcion del material
        /// </summary>
        public string DescripcionMaterial { get; private set; }

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

        public static Material Crear(string descripcionMaterial,
            string usuarioRegistro)
        {
            return new Material
            {
                DescripcionMaterial = descripcionMaterial,
                IndicadorEstado = "A",
                UsuarioRegistro = usuarioRegistro,
                UsuarioModificacion = usuarioRegistro,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }

        public void InactivarMaterial()
        {
            IndicadorEstado = "I";
            FechaModificacion = DateTime.Now;
            UsuarioModificacion = "RBELIZARIO";
        }
    }
}
