using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 private readonly AppContext _appContext = new AppContext(); 
    
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetRutaWithId(int id){
            return rutas.SingleOrDefault(b => b.id == id);
        }
        public Rutas Update(Rutas newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado = newRuta.tiempo_estimado;
                
            }
        return ruta;
        }

    }
    
} 