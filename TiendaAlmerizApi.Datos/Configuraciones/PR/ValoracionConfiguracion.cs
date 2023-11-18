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
    public class ValoracionConfiguracion : IEntityTypeConfiguration<Valoracion>
    {
        public void Configure(EntityTypeBuilder<Valoracion> builder)
        {
            builder.ToTable("PR_VALORACION", "PR");
            builder.HasKey(m => new { m.IdValoracion });

            builder.Property(m => m.IdValoracion).HasColumnName("ID_VALORACION");
            builder.Property(m => m.Comentario).HasColumnName("COMENTARIO");
            builder.Property(m => m.Puntaje).HasColumnName("PUNTAJE");
            builder.Property(m => m.IndicadorEstado).HasColumnName("IND_ESTADO");
            builder.Property(m => m.IdCliente).HasColumnName("ID_CLIENTE");
            builder.Property(m => m.FechaRegistro).HasColumnName("FEC_REGISTRO");
            builder.Property(m => m.UsuarioRegistro).HasColumnName("USU_REGISTRO");
            builder.Property(m => m.FechaModificacion).HasColumnName("FEC_MODIFICACION");
            builder.Property(m => m.UsuarioModificacion).HasColumnName("USU_MODIFICACION");
        }
    }
}