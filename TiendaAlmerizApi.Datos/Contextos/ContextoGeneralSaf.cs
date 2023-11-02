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

            #region PR
            modelBuilder.ApplyConfiguration(new ColorConfiguracion());

            #endregion PR
        }
    }
}
