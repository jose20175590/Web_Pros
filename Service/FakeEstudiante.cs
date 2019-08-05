using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class FakeEstudiante
    {
        private readonly List<Estudiante> _estudiantes;

        public FakeEstudiante()
        {
            _estudiantes = new List<Estudiante>()
            {
                new Estudiante() { estudianteId = 10,
                    nombre = "Orange Juice", apellido="Orange Tree", curso = "5.00M" },
                new Estudiante() { estudianteId =20,
                    nombre = "Diary Milk", apellido="Cow", curso = "4.00M" },
                new Estudiante() { estudianteId =30,
                    nombre = "Frozen Pizza", apellido="Uncle Mickey", curso = "12.00M" }
            };
        }

        public IEnumerable<Estudiante> GetAllItems()
        {
            return _estudiantes;
        }

        public Estudiante Add(Estudiante newItem)
        {
            _estudiantes.Add(newItem);
            return newItem;
        }

        public Estudiante GetById(int id)
        {
            return _estudiantes.Where(a => a.estudianteId == id)
                .FirstOrDefault();
        }

        public void Remove(int id)
        {
            var existing = _estudiantes.First(a => a.estudianteId == id);
            _estudiantes.Remove(existing);
        }
    }
}
