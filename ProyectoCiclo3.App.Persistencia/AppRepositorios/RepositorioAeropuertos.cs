using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAeropuertos
    {
        List<Aeropuertos> aeropuertos;
  private readonly AppContext _appContext = new AppContext(); 
    public RepositorioAeropuertos()
        {
           aeropuertos= new List<Aeropuertos>()
            {
                new Aeropuertos{id=1,nombre="SMR",ciudad="Santa Marta",pais="Colombia",coord_x= 74, coord_y= 1784},
                new Aeropuertos{id=2,nombre="BOG",ciudad="Bogota",pais="Colombia",coord_x= 14, coord_y= 1284},
                new Aeropuertos{id=3,nombre="STN",ciudad="Santiago",pais="Chile", coord_x= 24, coord_y= 1584}
            };


     
        }
 
        public IEnumerable<Aeropuertos> GetAll()
        {
              return _appContext.Aeropuertos;
        }
 
        public Aeropuertos GetAeropuertoWithId(int id){
            return aeropuertos.SingleOrDefault(b => b.id == id);
        }
        public Aeropuertos Update(Aeropuertos newAeropuerto){
            var aeropuerto= aeropuertos.SingleOrDefault(b => b.id == newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre =newAeropuerto.nombre;
                aeropuerto.ciudad=newAeropuerto.ciudad;
                aeropuerto.pais=newAeropuerto.pais;
                aeropuerto.coord_x=newAeropuerto.coord_x;
                aeropuerto.coord_y=newAeropuerto.coord_y;
          
            }
        return aeropuerto;
        }
    }
}
