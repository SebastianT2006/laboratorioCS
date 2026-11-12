using aplicacion_Personas.entidades;
using aplicacion_Personas.interfaces;
using aplicacion_Personas.nucleo;
using Microsoft.EntityFrameworkCore;

namespace aplicacion_Personas.implementaciones
{
    public class Conexion : DbContext, IConexion
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DatosGenerales.StringConexion()!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Personas>? Personas { get; set; }
    }
}
