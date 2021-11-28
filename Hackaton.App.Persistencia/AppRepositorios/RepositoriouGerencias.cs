using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;
 
namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositoriouGerencias
    
    {
        List<uGerencias> ugerencias;
        private readonly AppContext _appContext = new AppContext();   

        public IEnumerable<uGerencias> GetAll()
        {
            return _appContext.uGerencias;
        }

        public uGerencias Create(uGerencias newuGerente)
        {
           var adduGerente = _appContext.uGerencias.Add(newuGerente);
            _appContext.SaveChanges();
            return adduGerente.Entity;
        }
 
        public uGerencias GetuGerenteWithId(int id)
        {
            return _appContext.uGerencias.Find(id);
        }
        

        public uGerencias Update(uGerencias newuGerente)
        {
            var ugerente = _appContext.uGerencias.Find(newuGerente.id);
            if(ugerente != null){
                ugerente.fecha_novedad= newuGerente.fecha_novedad;
                ugerente.dias_novedad = newuGerente.dias_novedad;
                ugerente.texto_explicativo = newuGerente.texto_explicativo;
                
                _appContext.SaveChanges();
            }
        return ugerente;
        }

       public void Delete(int id)
        {
        var ugerente = _appContext.uGerencias.Find(id);
        if (ugerente == null)
            return;
        _appContext.uGerencias.Remove(ugerente);
        _appContext.SaveChanges();
        }


    }
}