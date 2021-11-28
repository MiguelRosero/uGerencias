using System.Collections.Generic;
using Hackaton.App.Dominio;
using System.Linq;
using System;
 
namespace Hackaton.App.Persistencia.AppRepositorios
{
    public class RepositorioEntidades
    {

        List<Entidades> entidades;
        private readonly AppContext _appContext = new AppContext();

        public IEnumerable<Entidades> GetAll()
        {
            
            return _appContext.Entidades;// retorna la informacion que se encuentra en Entidades(base de datos)
        }
        
        public Entidades Create(Entidades newEntidad)
        {
            var addEntidad = _appContext.Entidades.Add(newEntidad);
            _appContext.SaveChanges();
            return addEntidad.Entity;
        }
        
        public Entidades GetEntidadWithId(int id)
        {           
           return _appContext.Entidades.Find(id); 
        }

        public Entidades Update(Entidades newEntidad)
        {
            var entidad = _appContext.Entidades.Find(newEntidad.id);
            if(entidad != null)
            {
                entidad.razon_social = newEntidad.razon_social;
                entidad.nit = newEntidad.nit;
                entidad.direccion = newEntidad.direccion;
                entidad.ciudad = newEntidad.ciudad;
                entidad.telefono = newEntidad.telefono;
                entidad.webpage = newEntidad.webpage;
                entidad.sector = newEntidad.sector;
                entidad.servicio = newEntidad.servicio;
                             
                _appContext.SaveChanges(); //Guarda en base de Datos
            }
        return entidad;
        }

        public void Delete(int id)
        {
            
        var entidad = _appContext.Entidades.Find(id);
        if (entidad == null)
            return;
        _appContext.Entidades.Remove(entidad);
        _appContext.SaveChanges();
        }

    }
}
