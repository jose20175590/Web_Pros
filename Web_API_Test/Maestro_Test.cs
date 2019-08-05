using Microsoft.AspNetCore.Mvc;
using Model;
using Persistence;
using Service;
using Web_API.Controllers;
using Xunit;

namespace Web_API_Test
{
    public class Maestro_Test
    {
        MaestroController _maestroController;
        MaestroService _maestroService;
        TablaDbContext maestroDbContext;
        public Maestro_Test()
        {
            _maestroService = new MaestroService(maestroDbContext);
            _maestroController = new MaestroController(_maestroService);
        }

        [Fact]
        public void GET_ALL_MAESTRO_TEST()
        {
            var okResult = _maestroController.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void POST_MAESTRO_TEST()
        {
            Maestro maestro = new Maestro();
            maestro.nombre = "Luis Angel";
            maestro.apellido = "Romeo Guzman";
            maestro.materia = "Quimica Elemental";
            var okresult = _maestroController.Post(maestro);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void PUT_MAESTRO_TEST()
        {
            Maestro maestro = new Maestro();
            maestro.maestroId = 1;
            maestro.materia = "Fisica Cuantica";
            var okresult = _maestroController.Put(maestro);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void GET_MAESTRO_TEST()
        {
            int maestroId = 1;
            var okresult = _maestroController.Get(maestroId);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void DROP_MAESTRO_TEST()
        {
            int maestroId = 1;
            var okresult = _maestroController.Delete(maestroId);
            Assert.IsType<OkObjectResult>(okresult);
        }

    }
}
