using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;
 
namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositorioMigrantes
    {
        private readonly AppContext _appContext = new AppContext();   

        public IEnumerable<uGerencias> GetAll()
        {
            return _appContext.uGerencias;

        }
 
        public uGerencias GetuGerenteWithId(int id){
            return _appContext.uGerencias.Find(id);
        }
        public uGerencias Create(uGerencias newuGerente)
        {
           var adduGerente = _appContext.uGerencias.Add(newuGerente);
            _appContext.SaveChanges();
            return adduGerente.Entity;
        }

        public uGerencias Update(uGerencias newuGerente){
            var ugerente = _appContext.uGerencias.Find(newuGerente.id);
            if(ugerente != null){
                ugerente.nombre = newuGerente.fecha_novedad;
                ugerente.apellidos = newuGerente.dias_novedad;
                ugerente.tipo_documento = newuGerente.texto_explicativo;
                
                _appContext.SaveChanges();
            }
        return ugerente;
        }

       public void Delete(int id)
        {
        var ugerente = _appContext.uGerencias.Find(id);
        if (ugerente == null)
            return;
        _appContext.uGerentes.Remove(ugerente);
        _appContext.SaveChanges();
        }


    }
}