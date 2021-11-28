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
    
    public class ListuGerenciasModel : PageModel
    {
       
        private readonly RepositoriouGerencias repositoriouGerencias;
        
        public IEnumerable<uGerencias> uGerencias {get;set;}
        [BindProperty]
        public uGerencias uGerente {get;set;}
 
    public ListuGerenciasModel(RepositoriouGerencias repositoriouGerencias)
    {
        this.repositoriouGerencias=repositoriouGerencias;
     }
 
    public void OnGet()
    {
        uGerencias=repositoriouGerencias.GetAll();
    }

     public IActionResult OnPost()
    {
        if(uGerente.id>0)
        {
        repositoriouGerencias.Delete(uGerente.id);
        }
        return RedirectToPage("./List");
    }
    }
}