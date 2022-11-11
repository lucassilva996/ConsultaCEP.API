using ConsultaCEP.API.Model;
using ConsultaCEP.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RetornaCepController : ControllerBase
    {
        private readonly CepServices _cepService;
        public RetornaCepController(CepServices cepServices)
        {
            _cepService = cepServices;
        }

        [HttpGet("busca/{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCep([FromRoute] string cep)
        {
           var response = await _cepService.BuscarEndereco(cep);

            if(response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.DadosRetorno);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}
