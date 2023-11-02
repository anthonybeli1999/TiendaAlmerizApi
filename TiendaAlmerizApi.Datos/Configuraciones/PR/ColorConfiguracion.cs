using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TiendaAlmerizApi.Dominio.Entidades.PR;

namespace TiendaAlmerizApi.Datos.Configuraciones.PR
{
    public class ColorConfiguracion : IEntityTypeConfiguration<Color>
    {
        public void Configure(EntityTypeBuilder<Color> builder)
        {
            builder.ToTable("PR_COLORES", "PR");
            builder.HasKey(c => new { c.IdColor });

            builder.Property(c => c.IdColor).HasColumnName("ID_COLOR");
            builder.Property(c => c.DescripcionColor).HasColumnName("DES_COLOR");
            builder.Property(c => c.IndicadorEstado).HasColumnName("IND_ESTADO");
            builder.Property(c => c.FechaRegistro).HasColumnName("FEC_REGISTRO");
            builder.Property(c => c.UsuarioRegistro).HasColumnName("USU_REGISTRO");
            builder.Property(c => c.FechaModificacion).HasColumnName("FEC_MODIFICACION");
            builder.Property(c => c.UsuarioModificacion).HasColumnName("USU_MODIFICACION");
        }
    }
}
