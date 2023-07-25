using Microsoft.AspNetCore.Mvc;
using PeliculasAPi.Entidades;
using PeliculasAPi.Repositorios;

namespace PeliculasAPi.Controllers
{
    [Route("api/generos")]
    public class GenerosController
    {
        private readonly IRepositorio repositorio;

        public GenerosController(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }


        [HttpGet]
        public List<Genero> Get()
        {
            return repositorio.ObtenerTodosLosGeneros();
        }

    }
}
