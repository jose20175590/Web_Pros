using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public interface IMaestroService
    {
        IEnumerable<Maestro> GetAll();
        Maestro Get(int id);
        bool Add(Maestro model);
        bool update(Maestro model);
        bool Delete(int id);
    }

    public class MaestroService : IMaestroService
    {
        private readonly TablaDbContext _t_DbContext;
        public MaestroService(TablaDbContext t_DbContext)
        {
            _t_DbContext = t_DbContext;
        }

        public IEnumerable<Maestro> GetAll()
        {
            var result = new List<Maestro>();
            try
            {
                result = _t_DbContext.Maestro.ToList();
            }
            catch (Exception)
            {
            }
            return result;
        }
        public Maestro Get(int id)
        {
            var result = new Maestro();
            try
            {
                result = _t_DbContext.Maestro.Single(x => x.maestroId == id);
            }
            catch (Exception)
            {
            }
            return result;
        }
        public bool Add(Maestro model)
        {
            try
            {
                _t_DbContext.Add(model);
                _t_DbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Maestro model)
        {
            try
            {
                var originalModel = _t_DbContext.Maestro.Single(x =>
                        x.maestroId == model.maestroId);

                originalModel.nombre = model.nombre;
                originalModel.apellido = model.apellido;
                originalModel.materia = model.materia;

                _t_DbContext.Update(originalModel);
                _t_DbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                _t_DbContext.Entry(new Maestro { maestroId = id }).State = EntityState.Deleted;
                _t_DbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool update(Maestro model)
        {
            throw new NotImplementedException();
        }
    }
}
