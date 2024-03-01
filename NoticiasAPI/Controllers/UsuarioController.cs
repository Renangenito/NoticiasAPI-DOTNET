using Microsoft.AspNetCore.Mvc;
using NoticiasAPI.Data.Dtos;

namespace NoticiasAPI.Controllers
{
    [ApiController]
    [Route("[Controller")]
    public class UsuarioController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastroUsuario(CreateUsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
