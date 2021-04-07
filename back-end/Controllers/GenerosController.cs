namespace back_end.Controllers
{
    using back_end.Entidades;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/generos")]
    [ApiController]
    public class GenerosController: ControllerBase
    {
        private readonly ILogger<GenerosController> _logger;

        public GenerosController(ILogger<GenerosController> logger)
        {
            this._logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Genero>> Get()
        {
            //return _repositorio.ObtenerTodosLosGeneros();
            return new List<Genero>()
            {
                new Genero() {Id = 1 , Nombre = "Acción"},
            };
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Genero>> Get(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genero genero)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genero genero)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            throw new NotImplementedException();
        }
    }
}
