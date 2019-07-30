using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public interface IMateriaService
    {
        IEnumerable<Materia> GetAll();
        Materia Get(int id);
        bool Add(Materia model);
        bool update(Materia model);
        bool Delete(int id);
    }

    public class MateriaService : IMateriaService
    {
        private readonly TablaDbContext _t_DbContext;
        public MateriaService(TablaDbContext t_DbContext)
        {
            _t_DbContext = t_DbContext;
        }

        public IEnumerable<Materia> GetAll()
        {
            var result = new List<Materia>();
            try
            {
                result = _t_DbContext.Materia.ToList();
            }
            catch (Exception)
            {
            }
            return result;
        }
        public Materia Get(int id)
        {
            var result = new Materia();
            try
            {
                result = _t_DbContext.Materia.Single(x => x.materiaId == id);
            }
            catch (Exception)
            {
            }
            return result;
        }
        public bool Add(Materia model)
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

        public bool Update(Materia model)
        {
            try
            {
                var originalModel = _t_DbContext.Materia.Single(x =>
                        x.materiaId == model.materiaId);

                originalModel.materia = model.materia;
                originalModel.credito = model.credito;

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
                _t_DbContext.Entry(new Materia { materiaId = id }).State = EntityState.Deleted;
                _t_DbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool update(Materia model)
        {
            throw new NotImplementedException();
        }
    }
}
