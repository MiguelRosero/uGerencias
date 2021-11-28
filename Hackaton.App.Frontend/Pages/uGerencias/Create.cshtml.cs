using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Hackaton.App.Persistencia.AppRepositorios;
using Hackaton.App.Dominio;


namespace Hackaton.App.Frontend.Pages
{
    
    public class FormuGerenciasModel : PageModel
    {
        private readonly RepositoriouGerencias repositoriouGerencias;
        [BindProperty]
        public uGerencias uGerente { get; set; }

        public FormuGerenciasModel(RepositoriouGerencias repositoriouGerencias)
        {
            this.repositoriouGerencias = repositoriouGerencias;
        }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            uGerente = repositoriouGerencias.Create(uGerente);
            return RedirectToPage("./List");
        }

    }
}