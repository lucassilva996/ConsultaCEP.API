using ConsultaCEP.API.Model;
using ConsultaCEP.API.Repositories;
using ConsultaCEP.API.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]

        public async Task<ActionResult<dynamic>> Autentication([FromBody] User model)
        {
            var user = UsersRepository.Get(model.Username, model.Password);

            if (user == null)
            {
                return NotFound(new { message = "Usuário e senha digitados são inválidos!" });
            }

            var token = TokenGeneratorService.GenerateToken(user);
            user.Password = "";
            return new
            {
                user = user,
                token = token
            };
        }
    }
}
