using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Datos.Configuraciones.PR
{
    public class SubcategoriaConfiguracion : IEntityTypeConfiguration<Subcategoria>
    {
        public void Configure(EntityTypeBuilder<Subcategoria> builder)
        {
            builder.ToTable("PR_SUBCATEGORIA", "PR");
            builder.HasKey(m => new { m.IdSubcategoria });

            builder.Property(m => m.IdSubcategoria).HasColumnName("ID_SUBCATEGORIA");
            builder.Property(m => m.DescripcionSubcategoria).HasColumnName("DES_SUBCATEGORIA");
            builder.Property(m => m.IndicadorEstado).HasColumnName("IND_ESTADO");
            builder.Property(m => m.IdCategoria).HasColumnName("ID_CATEGORIA");
            builder.Property(m => m.FechaRegistro).HasColumnName("FEC_REGISTRO");
            builder.Property(m => m.UsuarioRegistro).HasColumnName("USU_REGISTRO");
            builder.Property(m => m.FechaModificacion).HasColumnName("FEC_MODIFICACION");
            builder.Property(m => m.UsuarioModificacion).HasColumnName("USU_MODIFICACION");
        }
    }
}
