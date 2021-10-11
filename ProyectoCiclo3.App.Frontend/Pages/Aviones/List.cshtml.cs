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
    public class ListAvionesModel : PageModel
    {
      private readonly RepositorioAviones repositorioAviones;
      
[BindProperty]
        public IEnumerable<Aviones> Aviones {get;set;}
 
    public ListAvionesModel(RepositorioAviones repositorioAviones)
    {
        this.repositorioAviones=repositorioAviones;
     }
 
    public void OnGet()
    {
    repositorioAviones.GetAll();
    }

    public IActionResult OnPost()
    {
        if(avion.id>0)
        {
      repositorioAviones.Delete(avion.id);
        }
        return RedirectToPage("./List");
    }

    }
}
