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
     
        public IEnumerable<Aeropuertos> GetAll()
        {
              return _appContext.Aeropuertos;
        }
 
        public Aeropuertos GetAeropuertoWithId(int id){
              return _appContext.Aeropuertos.Find(id);
        }
        public Aeropuertos Update(Aeropuertos newAeropuerto){
         var aeropuerto = _appContext.Aeropuertos.Find(newAeropuerto.id);
            if(aeropuerto != null){
                aeropuerto.nombre =newAeropuerto.nombre;
                aeropuerto.ciudad=newAeropuerto.ciudad;
                aeropuerto.pais=newAeropuerto.pais;
                aeropuerto.coord_x=newAeropuerto.coord_x;
                aeropuerto.coord_y=newAeropuerto.coord_y;
          
            }
        return aeropuerto;
        }
         public  Aeropuertos Create(Aeropuertos newAeropuerto)
         {
        var addAeropuerto = _appContext.Aeropuertos.Add(newAeropuerto);
        _appContext.SaveChanges();
        return addAeropuerto.Entity;
         }
    }
}
