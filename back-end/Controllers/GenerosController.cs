namespace back_end.Controllers
{
    using back_end.Entidades;
    using back_end.Entidades.Repositorios;
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
        public List<Genero> Get()
        {
            return _repositorio.ObtenerTodosLosGeneros();
        }

        //[HttpGet("{Id}")]
        //[HttpGet("{Id}/{nombre}")]
        //[HttpGet("{Id}/{nombre=pordefecto}")]
        [HttpGet("{Id:int}/{nombre=pordefecto}")]
        public Genero Get(int Id)
        {
            var genero = _repositorio.ObtenerPorId(Id);

            if (genero == null)
            {
                //return NotFound();
            }
            return genero;
        }

        [HttpPost]
        public void Post()
        {

        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }
    }
}
