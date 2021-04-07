namespace back_end.Controllers
{
    using AutoMapper;
    using back_end.DTOs;
    using back_end.Entidades;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Logging;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    [Route("api/generos")]
    [ApiController]
    public class GenerosController: ControllerBase
    {
        private readonly ILogger<GenerosController> _logger;
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public GenerosController(
            ILogger<GenerosController> logger,
            ApplicationDbContext context,
            IMapper mapper)
        {
            this._logger = logger;
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GeneroDTO>>> Get()
        {
            var generos = await context.Generos.ToListAsync();
            return mapper.Map<List<GeneroDTO>>(generos);

            //var resultado = new List<GeneroDTO>();
            //foreach (var genero in generos)
            //{
            //    resultado.Add(new GeneroDTO() { Id = genero.Id, Nombre = genero.Nombre });
            //}
            //return resultado;
        }

        [HttpGet("{Id:int}")]
        public ActionResult<Genero> Get(int Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneroCreacionDTO generoCreacionDTO)
        {
            var genero = mapper.Map<Genero>(generoCreacionDTO);
            context.Add(genero);
            await context.SaveChangesAsync();
            return NoContent();
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
