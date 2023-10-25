using _420BytesProyect.BM.General;
using _420BytesProyect.BM.General.Interfaces;
using _420BytesProyect.DT.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace _420BytesProyect.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IBMUsuarios IBMUsuarios;
        
        public UsuariosController(IBMUsuarios IBMUsuarios)
        {
            this.IBMUsuarios = IBMUsuarios; 
        }

        [HttpGet("ConsultaUsuarios")]
        public async Task<ActionResult<List<Usuario>>> ConsultarUsuario()
        {
            return await IBMUsuarios.ConsultaUsuarios();
        }
        [HttpGet("ConsultarUsuarioPorCedula")]
        public async Task<ActionResult<Usuario>>ConsultarUsuarioPorCedula(int Cedula)
        {
            return await IBMUsuarios.ConsultarUsuarioPorCedula(Cedula);
        }

        [HttpPost("RegistrarUsuario")]
        public async Task<ActionResult<bool>> RegistrarUsuario(Usuario Usuario)
        {
            return await IBMUsuarios.RegistrarUsuario(Usuario);
        }

        [HttpPut("ActualizarUsuario")]
        public async Task<ActionResult<bool>> ActualizarUsuario(Usuario Usuario)
        {
            return await IBMUsuarios.ActualizarUsuario(Usuario);

        }

        [HttpDelete("BorrarUsuario/{Cedula}")]
        public async Task<ActionResult<bool>> BorrarUsuario(int Cedula)
        {
            return await IBMUsuarios.BorrarUsuario(Cedula);

        }


    }
}
