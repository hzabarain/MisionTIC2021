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
    }
}
