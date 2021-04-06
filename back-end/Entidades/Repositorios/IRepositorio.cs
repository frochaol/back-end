using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Entidades.Repositorios
{
    public interface IRepositorio
    {
        Task<Genero> ObtenerPorId(int Id);
        List<Genero> ObtenerTodosLosGeneros();
    }
}
