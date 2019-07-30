using Microsoft.EntityFrameworkCore;
using Model;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public interface IEstudianteService
    {
        IEnumerable<Estudiante> GetAll();
        Estudiante Get(int id);
        bool Add(Estudiante model);
        bool update(Estudiante model);
        bool Delete(int id);
    }

    public class EstudianteService :  IEstudianteService
    {
        private readonly TablaDbContext _estudianteDbContext;
        public EstudianteService(TablaDbContext estudianteDbContext)
        {
            _estudianteDbContext = estudianteDbContext;
        }

        public IEnumerable<Estudiante> GetAll()
        {
            var result = new List<Estudiante>();
            try
            {
                result = _estudianteDbContext.Estudiante.ToList();
            }
            catch (Exception)
            {
            }
            return result;
        }
        public Estudiante Get(int id)
        {
            var result = new Estudiante();
            try
            {
                result = _estudianteDbContext.Estudiante.Single(x => x.estudianteId == id);
            }
            catch (Exception)
            {
            }
            return result;
        }
        public bool Add(Estudiante model)
        {
            try
            {
                _estudianteDbContext.Add(model);
                _estudianteDbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Estudiante model)
        {
            try
            {
                var originalModel = _estudianteDbContext.Estudiante.Single(x =>
                        x.estudianteId == model.estudianteId);

                originalModel.nombre = model.nombre;
                originalModel.apellido = model.apellido;
                originalModel.curso = model.curso;

                _estudianteDbContext.Update(originalModel);
                _estudianteDbContext.SaveChanges();
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
                _estudianteDbContext.Entry(new Estudiante { estudianteId = id }).State = EntityState.Deleted;
                _estudianteDbContext.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public bool update(Estudiante model)
        {
            throw new NotImplementedException();
        }
    }
}
