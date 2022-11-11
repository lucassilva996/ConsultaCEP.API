using ConsultaCEP.API.Model;
using ConsultaCEP.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RetornaCepController : ControllerBase
    {
        private readonly CepServices _cepService;
        public RetornaCepController(CepServices cepServices)
        {
            _cepService = cepServices;
        }

        [HttpGet]
        public async Task<EnderecoModel> GetCep()
        {
            _cepService
        }
    }
}
