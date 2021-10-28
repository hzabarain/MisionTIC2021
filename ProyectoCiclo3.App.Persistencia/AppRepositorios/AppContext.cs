using Microsoft.EntityFrameworkCore;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Aviones> Aviones { get; set; }
        public DbSet<Aeropuertos> Aeropuertos { get; set; }
        public DbSet<Rutas> Rutas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
               optionsBuilder.UseSqlServer("Data Source =serverteam10grupo20.database.windows.net; Initial Catalog = ProyectoCiclo3; User ID=misiontic_bd_admin_t10;Password=kpYd^7JMSKtH;");
            }
        }
    }
}
