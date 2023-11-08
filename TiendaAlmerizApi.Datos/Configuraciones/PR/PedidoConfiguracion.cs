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
    public class PedidoConfiguracion : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("PR_Pedido", "PR");
            builder.HasKey(m => new { m.IdPedido });

            builder.Property(m => m.IdPedido).HasColumnName("ID_PEDIDO");
            builder.Property(m => m.IndicadorEstado).HasColumnName("IND_ESTADO");
            builder.Property(m => m.Cantidad).HasColumnName("CANTIDAD");
            builder.Property(m => m.MontoTotal).HasColumnName("MONTO_TOTAL");
            builder.Property(m => m.MetodoPago).HasColumnName("METODO_PAGO");
            builder.Property(m => m.FechaPedido).HasColumnName("FEC_PEDIDO");
            builder.Property(m => m.IdCliente).HasColumnName("ID_CLIENTE");
            builder.Property(m => m.FechaRegistro).HasColumnName("FEC_REGISTRO");
            builder.Property(m => m.UsuarioRegistro).HasColumnName("USU_REGISTRO");
            builder.Property(m => m.FechaModificacion).HasColumnName("FEC_MODIFICACION");
            builder.Property(m => m.UsuarioModificacion).HasColumnName("USU_MODIFICACION");
        }
    }
}
