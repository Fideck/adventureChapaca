using api_aventurachapaca.Context;
using api_aventurachapaca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_aventurachapaca.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationContext contexto;

        public PersonController(ApplicationContext context)
        {
            this.contexto = context;
        }
        [HttpPost]
        public async Task<ActionResult<List<PersonModel>>> AgregarPersona(PersonModel persona)
        {

            if (persona == null)
            {
                return BadRequest();
            }
            else
            {
                contexto.Person.Add(persona);
                await contexto.SaveChangesAsync();
                return Ok("Persona agregada con exito");
            }
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonModel>>> ObtenerPersonas()
        {
            return await contexto.Person.ToListAsync();
        }
    }
}
