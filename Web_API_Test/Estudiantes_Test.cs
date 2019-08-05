using Microsoft.AspNetCore.Mvc;
using Model;
using Persistence;
using Service;
using Web_API.Controllers;
using Xunit;

namespace Web_API_Test
{
    public class Estudiantes_Test
    {
        EstudianteController _estudianteController;
        EstudianteService _estudianteService;
        TablaDbContext estudianteDbContext;
        public Estudiantes_Test()
        {
            _estudianteService = new EstudianteService(estudianteDbContext);
            _estudianteController = new EstudianteController(_estudianteService);
        }

        [Fact]
        public void GET_ALL_ESTUDIANTES_TEST()
        {
            var okResult = _estudianteController.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void POST_ESTUDIANTE_TEST()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.estudianteId = 10;
            estudiante.nombre = "Jose";
            estudiante.apellido = "Perez";
            estudiante.curso = "5to A";
            var okresult = _estudianteController.Post(estudiante);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void PUT_ESTUDIANTE_TEST()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.estudianteId = 10;
            estudiante.nombre = "Jose Angel";
            estudiante.apellido = "Perez Arroyo";
            estudiante.curso = "5to C";
            var okresult = _estudianteController.Put(estudiante);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void GET_ESTUDIANTE_TEST()
        {
            int estudianteId = 10;
            var okresult = _estudianteController.Get(estudianteId);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void DROP_ESTUDIANTE_TEST()
        {
            int estudianteId = 10;
            var okresult = _estudianteController.Delete(estudianteId);
            Assert.IsType<OkObjectResult>(okresult);
        }

    }
}
