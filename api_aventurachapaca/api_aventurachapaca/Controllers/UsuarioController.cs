using api_aventurachapaca.Context;
using api_aventurachapaca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_aventurachapaca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly ApplicationContext contexto;

        public UsuarioController(ApplicationContext context)
        {
            this.contexto = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> ObtenerUsuarios()
        {
            var datos = from us in this.contexto.Usuario
                        join p in this.contexto.Person on us.PersonId equals p.Id
                        select new UserModel
                        {
                           Id= us.Id,
                           usuario=us.usuario,
                           tipousuario=us.tipousuario,
                           estado=us.estado,
                           Person=us.Person
                       
                        };

            return await datos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<UserModel>>> AgregarUsuario(UserModel user)
        {
            var usuario = await contexto.Usuario.FirstOrDefaultAsync(x => x.usuario == user.usuario);
            if (usuario == null)
            {
                contexto.Usuario.Add(user);
                await contexto.SaveChangesAsync();
                return Ok();

            }
            else
            {
                return BadRequest("Este usuario ya existe");

            }
        }
        [HttpPut("baja/{id:int}")]
        public async Task<ActionResult<List<UserModel>>> EliminarLogico(int id, UserModel user)
        {
            UserModel usuario = await contexto.Usuario.FirstOrDefaultAsync(x => x.Id == id);
            if (usuario != null)
            {
                usuario.estado = user.estado;
                await contexto.SaveChangesAsync();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> EditarUsuario(int id, UserModel usuario)
        {

            UserModel user = await contexto.Usuario.FirstOrDefaultAsync(x => x.Id == id);
            PersonModel existen = await contexto.Person.FirstOrDefaultAsync(x => x.Id == user.PersonId);
            //Role r=await contexto.Rol.FirstOrDefaultAsync(x=> x.Id== user.RolId);
            if (user == null)
            {
                return BadRequest("No se encontró el usuario");
            }
            else
            {
                user.usuario = usuario.usuario;
                user.estado = usuario.estado;
                user.contrasenia= usuario.contrasenia;
                user.tipousuario= usuario.tipousuario;
                existen.nombre = usuario.Person.nombre;
                existen.apeliido = usuario.Person.apeliido;
                existen.tipodocumento = usuario.Person.tipodocumento;
                existen.genero = usuario.Person.genero;
                existen.fechanac = usuario.Person.fechanac;
                existen.telefono = usuario.Person.telefono;
                existen.documento= usuario.Person.documento;
                await contexto.SaveChangesAsync();
                return Ok();
            }
        }

    }
}
