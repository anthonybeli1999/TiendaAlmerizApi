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
    public class ClienteConfiguracion : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("PR_CLIENTE", "PR");
            builder.HasKey(m => new { m.IdCliente });

            builder.Property(m => m.IdCliente).HasColumnName("ID_CLIENTE");
            builder.Property(m => m.NombreCliente).HasColumnName("NOMBRE_CLIENTE");
            builder.Property(m => m.ApellidoCliente).HasColumnName("APELLIDO_CLIENTE");
            builder.Property(m => m.DniCliente).HasColumnName("DNI_CLIENTE");
            builder.Property(m => m.DireccionenvioCliente).HasColumnName("DIRECCIONENVIO_CLIENTE");
            builder.Property(m => m.EmailCliente).HasColumnName("EMAIL_CLIENTE");
            builder.Property(m => m.ContraseñaCliente).HasColumnName("CONTRASEÑA_CLIENTE");
            builder.Property(m => m.CelularCliente).HasColumnName("CELULAR_CLIENTE");
            builder.Property(m => m.IndicadorEstado).HasColumnName("IND_ESTADO");
            builder.Property(m => m.FechaRegistro).HasColumnName("FEC_REGISTRO");
            builder.Property(m => m.UsuarioRegistro).HasColumnName("USU_REGISTRO");
            builder.Property(m => m.FechaModificacion).HasColumnName("FEC_MODIFICACION");
            builder.Property(m => m.UsuarioModificacion).HasColumnName("USU_MODIFICACION");
        }
    }
}