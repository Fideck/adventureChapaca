using api_aventurachapaca.Context;
using api_aventurachapaca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace api_aventurachapaca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TourController : Controller
    {
        private readonly ApplicationContext contexto;

        public TourController(ApplicationContext context)
        {
            this.contexto = context;
        }

        [HttpPost]
        public async Task<ActionResult<List<TourModel>>> AgregarTour(TourModel tour)
        {
            TourModel t = await contexto.Tour.FirstOrDefaultAsync(x => x.Id ==tour.Id );
            if (t != null)
            {
                return BadRequest("Este tour ya existe");
            }
            else
            {
                contexto.Tour.Add(tour);
                await contexto.SaveChangesAsync();
                return Ok();

            }
           
        }
        [HttpGet]
        public async Task<ActionResult<List<TourModel>>> ObtenerTours()
        {

            return await contexto.Tour.ToListAsync();
        }
        // GET: api/Visitas id
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<TourModel>>> Obtenertour(int id)
        {
            var datos = from t in this.contexto.Tour
                        join p in this.contexto.Person on t.PersonId equals p.Id
                        join pa in this.contexto.Pago on t.Id equals pa.Id
            where t.Id == id
                        select new TourModel
                        {
                            Id = t.Id,
                            nombre= t.nombre,
                            descripcion= t.descripcion,
                            precio= t.precio,
                            duracion= t.duracion,
                            adicionales= t.adicionales,
                            recomendaciones= t.recomendaciones, 
                            estado= t.estado,
                            person= t.person,
                            Pago=t.Pago
                        };
            return await datos.ToListAsync();
        }


        //PUT: api/Tour
        [HttpPut("{id:int}")]
        public async Task<ActionResult<List<TourModel>>> EditarTour(int id, TourModel tour)
        {
            TourModel t = await contexto.Tour.FirstOrDefaultAsync(x => x.Id == id);
            PersonModel existen = await contexto.Person.FirstOrDefaultAsync(x => x.Id == tour.PersonId);
            if (t == null)
            {
                return BadRequest("No se encontro la Institucion");
            }
            else
            {
                t.nombre = tour.nombre;
                t.descripcion = tour.descripcion;
                t.precio = tour.precio;
                t.duracion = tour.duracion;
                t.adicionales = tour.adicionales;
                t.recomendaciones = tour.recomendaciones;
                t.estado = tour.estado;
                existen.nombre = tour.person.nombre;
                existen.apeliido = tour.person.apeliido;
                existen.tipodocumento = tour.person.tipodocumento;
                existen.genero = tour.person.genero;
                existen.fechanac = tour.person.fechanac;
                existen.telefono = tour.person.telefono;
                existen.documento = tour.person.documento;
                await contexto.SaveChangesAsync();
                return Ok();
            }
        }
        [HttpPut("baja/{id:int}")]
        public async Task<ActionResult<List<TourModel>>> EliminarLogico(int id, TourModel tour)
        {
            TourModel t = await contexto.Tour.FirstOrDefaultAsync(x => x.Id == id);
            if (t != null)
            {
                t.estado = tour.estado;
                await contexto.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
    }
