using api_aventurachapaca.Context;
using api_aventurachapaca.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace api_aventurachapaca.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly ApplicationContext contexto;
        public dynamic du;
        public UserController(ApplicationContext context)
        {
            this.contexto = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<List<UserModel>>> ObtenerUsuarios()
        {
            var datos = from us in this.contexto.Usuario
                        join p in this.contexto.Person on us.PersonId equals p.Id
                        select new UserModel
                        {
                            Id = us.Id,
                            usuario = us.usuario,
                            tipousuario = us.tipousuario,
                            contrasenia = us.contrasenia,
                            correo = us.correo,
                            Person = us.Person
                        };
            return await datos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<List<UserModel>>> AgregarUsuario(UserModel user)
        {
            var usuario = await contexto.Usuario.FirstOrDefaultAsync(x => x.usuario == user.usuario);
            if (usuario == null)
            {
                var i = Encrypt(user.contrasenia);
                user.contrasenia = i;
                contexto.Usuario.Add(user);
                await contexto.SaveChangesAsync();
                return Ok();

            }
            else
            {
                return BadRequest("Este usuario ya existe");

            }


        }
        public static string Encrypt(string passw)
        {
            string hash = "OH6wxsAWhwo=";
            byte[] data = UTF8Encoding.UTF8.GetBytes(passw);


            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateEncryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(result);
        }

        public static string Descrypt(string passwDecode)
        {
            string hash = "OH6wxsAWhwo=";
            byte[] data = Convert.FromBase64String(passwDecode);

            MD5 md5 = MD5.Create();
            TripleDES tripleDES = TripleDES.Create();

            tripleDES.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
            tripleDES.Mode = CipherMode.ECB;

            ICryptoTransform transform = tripleDES.CreateDecryptor();
            byte[] result = transform.TransformFinalBlock(data, 0, data.Length);

            return UTF8Encoding.UTF8.GetString(result);
        }
    }
}
