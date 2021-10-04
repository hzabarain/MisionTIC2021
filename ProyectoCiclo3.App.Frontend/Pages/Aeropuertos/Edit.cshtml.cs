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
    public class EditAeropuertoModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioAeropuertos;
      [BindProperty]
              public Aeropuertos aeropuerto {get;set;}
 
        public EditAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
       {
            this.repositorioAeropuertos=repositorioAeropuertos;
       }
 
        public IActionResult OnGet(int aeropuertoId)
        {

                aeropuerto=repositorioAeropuertos.GetAeropuertoWithId(aeropuertoId);
                return Page();
 
        }
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(aeropuerto.id>0)
            {
            aeropuerto = repositorioAeropuertos.Update(aeropuerto);
            }
            return Page();
        }
    }
}


