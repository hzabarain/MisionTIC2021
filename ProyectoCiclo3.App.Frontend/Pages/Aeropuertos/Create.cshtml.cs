using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;

namespace ProyectoCiclo3.App.Frontend.Pages
{

    
    public class FormAeropuertoModel : PageModel
    {
       private readonly RepositorioAeropuertos repositorioAeropuertos;
      [BindProperty]
              public Aeropuertos aeropuerto{get;set;}

        public FormAeropuertoModel(RepositorioAeropuertos repositorioAeropuertos)
       {
            this.repositorioAeropuertos=repositorioAeropuertos;
       }
         public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }     
         RepositorioAeropuertos Create (aeropuerto);
            return RedirectToPage("./List");
    }
}
}