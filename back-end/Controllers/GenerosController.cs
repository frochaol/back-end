namespace back_end.Controllers
{
    using back_end.Entidades;
    using back_end.Entidades.Repositorios;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    [Route("api/generos")]
    [ApiController]
    public class GenerosController: ControllerBase
    {
        private readonly IRepositorio _repositorio;

        public GenerosController(IRepositorio repositorio)
        {
            this._repositorio = repositorio;
        }

        [HttpGet]
        [HttpGet("listado")]
        [HttpGet("/listadogeneros")]
        //[ResponseCache(Duration = 60)]
        //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        public ActionResult<List<Genero>> Get()
        {
            return _repositorio.ObtenerTodosLosGeneros();
        }

        //[HttpGet("{Id}")]
        //[HttpGet("{Id}/{nombre}")]
        //[HttpGet("{Id}/{nombre=pordefecto}")]
        [HttpGet("{Id:int}/{nombre=pordefecto}")]
        public async Task<ActionResult<Genero>> Get(int Id)
        {
            var genero = await _repositorio.ObtenerPorId(Id);

            if (genero == null)
            {
                return NotFound();
            }
            return genero;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genero genero)
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genero genero)
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}
