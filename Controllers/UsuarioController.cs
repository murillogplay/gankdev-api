
using GankdevApi.Interfaces;
using Microsoft.AspNetCore.Mvc; 

namespace GankdevApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    { 
        private readonly IUsuarioServices _usuarioServices;
        public UsuarioController(IUsuarioServices usuarioServices)
        { 
            _usuarioServices = usuarioServices;   
        }

        [HttpGet]
        public IActionResult GetUsuario()
        {
            return Ok(_usuarioServices.GetUsuarios());
        }
         
    }
}
