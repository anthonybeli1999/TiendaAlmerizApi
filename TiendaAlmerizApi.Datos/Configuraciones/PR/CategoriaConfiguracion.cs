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
    public class CategoriaConfiguracion : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("PR_CATEGORIA", "PR");
            builder.HasKey(m => new { m.IdCategoria });

            builder.Property(m => m.IdCategoria).HasColumnName("ID_CATEGORIA");
            builder.Property(m => m.DescripcionCategoria).HasColumnName("DES_CATEGORIA");
            builder.Property(m => m.IndicadorEstado).HasColumnName("IND_ESTADO");
            builder.Property(m => m.FechaRegistro).HasColumnName("FEC_REGISTRO");
            builder.Property(m => m.UsuarioRegistro).HasColumnName("USU_REGISTRO");
            builder.Property(m => m.FechaModificacion).HasColumnName("FEC_MODIFICACION");
            builder.Property(m => m.UsuarioModificacion).HasColumnName("USU_MODIFICACION");
        }
    }
}
