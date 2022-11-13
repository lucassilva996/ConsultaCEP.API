using AutoMapper;
using ConsultaCEP.API.DTO;
using ConsultaCEP.API.Exceptions;
using ConsultaCEP.API.Interfaces;
using ConsultaCEP.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IRestService _restService;

        public EnderecoService(IMapper mapper, IRestService restService)
        {
            _mapper = mapper;
            _restService = restService;
        }

        public async Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _restService.BuscarEnderecoPorCEP(cep);

            return _mapper.Map<ResponseGenerico<EnderecoResponse>>(endereco);
        }
    }
}
