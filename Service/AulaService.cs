using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public interface IAulaService
    {
        IEnumerable<Aula> GetAll();
        Aula Get(int id);
        bool Add(Aula model);
        bool update(Aula model);
        bool Delete(int id);
    }

    public class AulaService : IAulaService
    {
        private readonly TablaDbContext _t_DbContext;
        public AulaService(TablaDbContext t_DbContext)
        {
            _t_DbContext = t_DbContext;
        }

        public IEnumerable<Aula> GetAll()
        {
            var result = new List<Aula>();
            try
            {
                result = _t_DbContext.Aula.ToList();
            }
            catch (Exception)
            {
            }
            return result;
        }
        public Aula Get(int id)
        {
            var result = new Aula();
            try
            {
                result = _t_DbContext.Aula.Single(x => x.aulaId == id);
            }
            catch (Exception)
            {
            }
            return result;
        }
        public bool Add(Aula model)
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

        public bool Update(Aula model)
        {
            try
            {
                var originalModel = _t_DbContext.Aula.Single(x =>
                        x.aulaId == model.aulaId);
                originalModel.aula = model.aula;
                originalModel.capacidad = model.capacidad;
                originalModel.seccion = model.seccion;

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
                _t_DbContext.Entry(new Aula { aulaId = id }).State = EntityState.Deleted;
                _t_DbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool update(Aula model)
        {
            throw new NotImplementedException();
        }
    }
}
