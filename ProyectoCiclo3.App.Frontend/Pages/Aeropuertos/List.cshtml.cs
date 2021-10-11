using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class ListAeropuertosModel : PageModel
    {
  private readonly RepositorioAeropuertos repositorioRutas;
        public IEnumerable<Aeropuertos> Rutass {get;set;}
 
    public ListAeropuertosModel(RepositorioAeropuertos repositorioAviones)
    {
        this.repositorioAeropuertos=repositorioAeropuertos;
     }
 
    public void OnGet()
    {
        Rutas=repositorioAeropuertos.GetAll();
    }

    public IActionResult OnPost()
    {
        if(Aeropuerto.id>0)
        {
        Aeropuerto= repositorioAeropuertos.Delete(Aeropuerto.id);
        }
        return RedirectToPage("./List");
    }

    }
}