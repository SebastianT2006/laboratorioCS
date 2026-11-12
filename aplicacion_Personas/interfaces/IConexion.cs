using aplicacion_Personas.entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace aplicacion_Personas.interfaces
{
    public interface IConexion
    {
        DbSet<Personas>? Personas { get; set; }
        
        EntityEntry<T> Entry<T>(T entity) where T : class;
        int SaveChanges();
    }
}
