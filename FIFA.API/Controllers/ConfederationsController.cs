using FIFA.API.Data;
using Microsoft.AspNetCore.Mvc;

namespace FIFA.API.Controllers
{
    [ApiController]
    // Esto es un "Data Anotation"

    [Route("/api/confederations")]
    // Acá le digo que todos los métodos de este controlador van a correr sobre directorio Api
    // y el endpoint se llama countries. Todo método que ejecute en esta ruta toma a countries

    public class ConfederationsController : ControllerBase
    // Para que entienda que es un controlador de API(lo pongo a heredar, o sea :)
    {
        private readonly DataContext _context;

        public ConfederationsController(DataContext context)
        {

            _context = context;
        }


    }

}