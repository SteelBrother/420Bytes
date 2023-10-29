using _420BytesProyect.BM.General.Interfaces;
using _420BytesProyect.DT.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace _420BytesProyect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {

        private IBMUsuarios IBMUsuarios;

        public AuthController(IBMUsuarios IBMUsuarios)
        {
            this.IBMUsuarios = IBMUsuarios;
        }

        [HttpGet("Login/{NickName}/{Password}")]
        public async Task<ActionResult<Usuario>> Login(string NickName, string Password)
        {
            return await IBMUsuarios.Login(NickName, Password);
        }

    }
}
