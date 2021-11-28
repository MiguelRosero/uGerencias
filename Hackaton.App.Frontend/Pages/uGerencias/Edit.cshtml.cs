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
    
    public class EdituGerenciasModel : PageModel
    {
        private readonly RepositoriouGerencias repositoriouGerencias;

        [BindProperty]
        public uGerencias uGerente {get; set;}

        public EdituGerenciasModel(RepositoriouGerencias repositoriouGerencias)
        {
            this.repositoriouGerencias = repositoriouGerencias;
        }

        public IActionResult OnGet(int ugerenteId)
        {
            uGerente = repositoriouGerencias.GetuGerenteWithId(ugerenteId);
            return Page();

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (uGerente.id>0)
            {
                uGerente = repositoriouGerencias.Update(uGerente);
            }
            return RedirectToPage("./List");
        }

    }
}