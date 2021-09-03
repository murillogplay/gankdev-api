
using GankdevApi.Interfaces;
using GankdevApi.Models;
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
        
        [HttpGet("{id}", Name = "GetUsuario")]
        public IActionResult GetUsuario(string id){
           return Ok( _usuarioServices.GetUsuario(id));
        }
        
        [HttpPost]
        public IActionResult AddUsuario(Usuario usuario){
            
            _usuarioServices.AddUsuario(usuario);

            return CreatedAtRoute("GetUsuario", new { id = usuario.Id}, usuario);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(string id){
            _usuarioServices.DeleteUsuario(id);
            return NoContent();
        }
        [HttpPut]
        public IActionResult UpdateUsuario(Usuario usuario){
            return Ok(_usuarioServices.UpdateUsuario(usuario));
        }
        [HttpPost("authenticate")]
        public IActionResult Autenthicate(Usuario usuario){
            return Ok(_usuarioServices.Authenticate(usuario));
        }
    }
}
