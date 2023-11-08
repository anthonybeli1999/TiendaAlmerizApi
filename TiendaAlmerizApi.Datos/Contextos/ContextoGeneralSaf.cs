using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaAlmerizApi.Datos.Configuraciones.PR;

namespace TiendaAlmerizApi.Datos.Contextos
{
    public class ContextoGeneralSaf : ContextoBaseSaf<ContextoGeneralSaf>
    {
        public ContextoGeneralSaf(DbContextOptions<ContextoGeneralSaf> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ColorConfiguracion());
            modelBuilder.ApplyConfiguration(new MaterialConfiguracion());
            modelBuilder.ApplyConfiguration(new CategoriaConfiguracion());
            modelBuilder.ApplyConfiguration(new SubcategoriaConfiguracion());
            modelBuilder.ApplyConfiguration(new ClienteConfiguracion());
            modelBuilder.ApplyConfiguration(new ValoracionConfiguracion());
            modelBuilder.ApplyConfiguration(new PedidoConfiguracion());
            #region PR
            modelBuilder.ApplyConfiguration(new ColorConfiguracion());

            #endregion PR
        }
    }
}
