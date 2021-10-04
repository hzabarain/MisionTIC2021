using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
           aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="Boeing",modelo= 2020,numero_banos= 4, numero_asientos= 184, capacidad_max_carga=150},
                new Aviones{id=2,marca="Tucan",modelo= 2021,numero_banos= 1, numero_asientos= 14, capacidad_max_carga=200},
                new Aviones{id=3,marca="Alcaraban",modelo= 2000,numero_banos= 2, numero_asientos= 4, capacidad_max_carga=80}
            };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetAvionWithId(int id){
            return aviones.SingleOrDefault(b => b.id == id);
        }
        public Aviones Update(Aviones newAvion){
            var avion= aviones.SingleOrDefault(b => b.id == newAvion.id);
            if(avion != null){
                avion.marca = newAvion.marca;
                avion.modelo = newAvion.modelo;
                avion.numero_banos = newAvion.numero_banos;
                avion.numero_asientos = newAvion.numero_asientos;
                avion.capacidad_max_carga = newAvion.capacidad_max_carga;
            }
        return avion;
        }
        public Aviones Create(Aviones newAvion)
        {
           if(aviones.Count > 0){
           newAvion.id=aviones.Max(r => r.id) +1; 
            }else{
               newAvion.id = 1; 
            }
           aviones.Add(newAvion);
           return newAvion;
        }


    }
    
}
