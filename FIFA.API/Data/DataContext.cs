using FIFA.Shared.Entities;
using Microsoft.EntityFrameworkCore;

// En DataContext se genera la conexión a la BD
// Y lo que se hace acá sirve para mapear las entidades a la BD

namespace FIFA.API.Data
{
    public class DataContext:DbContext // los dos puntos refieren a una herencia que es de donde nos vamos a conectar a la BD
    {
        public DataContext(DbContextOptions<DataContext>options):base(options) // Este es el constructor, y el DbContext está apuntando a options
        {
                
        }

        public DbSet<Country>Countries { get; set; } // es el que me detecta que es una tabla y que la va mandar a la BD. A cada entidad hay que hacerle
  
        // Todo lo que se siga a la entidad hace las veces de controlador(en este caso el plural de la entidad)

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasIndex(x => x.Name).IsUnique(); // Con esto garantizamos que el nombre(de esta entidad) no se repita
        }

    }
}
