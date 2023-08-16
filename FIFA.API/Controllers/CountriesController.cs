using FIFA.API.Data;
using FIFA.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FIFA.API.Controllers
{
    [ApiController]
    // Esto es un "Data Anotation"

    [Route("/api/countries")]
    // Acá le digo que todos los métodos de este controlador van a correr sobre directorio Api
    // y el endpoint se llama countries. Todo método que ejecute en esta ruta toma a countries

    public class CountriesController : ControllerBase
    // Para que entienda que es un controlador de API(lo pongo a heredar, o sea :)
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {

            _context = context;
        }

        [HttpPost]
        // Post es el Crear en el CRUD
        public async Task<ActionResult> Post(Country country)
        // Métodos async garantizan una respuesta más optima cuando esté mostrando los resultados
        // Action Result
        {

            _context.Add(country);
         // Se usa add porque post es crear

            await _context.SaveChangesAsync();
        // Siempre al usar un async debe usarse debajo un await

            return Ok();
        // Si you usé Post, debo retornar


    }

        [HttpGet]
        // Get es el LECTURA en el CRUD

        public async Task<ActionResult> Get()
        {
           return Ok (await _context.Countries.ToListAsync());
             
        }
    }

}
    

