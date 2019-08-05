using Microsoft.AspNetCore.Mvc;
using Model;
using Persistence;
using Service;
using Web_API.Controllers;
using Xunit;

namespace Web_API_Test
{
    public class Aula_Test
    {
        AulaController _aulaController;
        AulaService _aulaService;
        TablaDbContext aulaDbContext;
        public Aula_Test()
        {
            _aulaService = new AulaService(aulaDbContext);
            _aulaController = new AulaController(_aulaService);
        }

        [Fact]
        public void GET_ALL_AULA_TEST()
        {
            var okResult = _aulaController.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void POST_AULA_TEST()
        {
            Aula aula = new Aula();
            aula.aula = "5to";
            aula.seccion = "D";
            aula.capacidad = 10;
            var okresult = _aulaController.Post(aula);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void PUT_AULA_TEST()
        {
            Aula aula = new Aula();
            aula.aulaId = 1;
            aula.aula = "5to";
            aula.seccion = "C";
            aula.capacidad = 20;
            var okresult = _aulaController.Put(aula);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void GET_AULA_TEST()
        {
            int aulaId = 1;
            var okresult = _aulaController.Get(aulaId);
            Assert.IsType<OkObjectResult>(okresult);
        }
        [Fact]
        public void DROP_AULA_TEST()
        {
            int aulaId = 10;
            var okresult = _aulaController.Delete(aulaId);
            Assert.IsType<OkObjectResult>(okresult);
        }

    }
}
