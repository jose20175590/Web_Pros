using Microsoft.AspNetCore.Mvc;
using Model;
using Persistence;
using Service;
using Web_API.Controllers;
using Xunit;

namespace Web_API_Test
{
    public class Materia_Test
    {
        MateriaController _materiaController;
        MateriaService _materiaService;
        TablaDbContext materiaDbContext;
        public Materia_Test()
        {
            _materiaService = new MateriaService(materiaDbContext);
            _materiaController = new MateriaController(_materiaService);
        }

        [Fact]
        public void GET_ALL_MATERIA_TEST()
        {
            var okResult = _materiaController.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void POST_MATERIA_TEST()
        {
            Materia materia = new Materia();
            materia.materia = "Quimica Elemental";
            materia.credito = "10 Creditos";
            var okresult = _materiaController.Post(materia);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void PUT_MATERIA_TEST()
        {
            Materia materia = new Materia();
            materia.materiaId = 1;
            materia.materia = "Quimica Elemental";
            materia.credito = "10 Creditos";
            var okresult = _materiaController.Put(materia);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void GET_MATERIA_TEST()
        {
            int materiaId = 1;
            var okresult = _materiaController.Get(materiaId);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void DROP_MATERIA_TEST()
        {
            int materiaId = 10;
            var okresult = _materiaController.Delete(materiaId);
            Assert.IsType<OkObjectResult>(okresult);
        }

    }
}
