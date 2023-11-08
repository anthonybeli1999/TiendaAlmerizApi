using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaAlmerizApi.Dominio.Entidades.PR
{
    /// <summary>
    /// Clase que representa la entidad subcategorias
    /// </summary>
    public class Subcategoria
    {
        /// <summary>
        /// Id de la subcategoria
        /// </summary>
        public int IdSubcategoria { get; private set; }

        /// <summary>
        /// Descripcion de subcategoria
        /// </summary>
        public string DescripcionSubcategoria { get; private set; }

        /// <summary>
        /// Indicador estado
        /// </summary>
        public string IndicadorEstado { get; private set; }

        /// <summary>
        /// Id de la subcategoria
        /// </summary>
        public int IdCategoria { get; private set; }

        /// <summary>
        /// Fecha registro
        /// </summary>
        /// 

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

        public static Subcategoria Crear(string DescripcionSubcategoria,int IdCategoria,
            string usuarioRegistro)
        {
            return new Subcategoria
            {
                DescripcionSubcategoria = DescripcionSubcategoria,
                IdCategoria = IdCategoria,
                IndicadorEstado = "A",
                UsuarioRegistro = usuarioRegistro,
                UsuarioModificacion = usuarioRegistro,
                FechaRegistro = DateTime.Now,
                FechaModificacion = DateTime.Now
            };
        }

        public void InactivarSubcategoria()
        {
            IndicadorEstado = "I";
            FechaModificacion = DateTime.Now;
            UsuarioModificacion = "RBELIZARIO";
        }
    }
}
