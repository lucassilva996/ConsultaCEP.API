using AutoMapper;
using ConsultaCEP.API.DTO;
using ConsultaCEP.API.Exceptions;
using ConsultaCEP.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Service
{
    public class CepServices : ICepServices
    {
        private readonly IMapper _mapper;
        private readonly ICepServices _cepServices;

        public CepServices(IMapper mapper, ICepServices cepServices)
        {
            _mapper = mapper;
            _cepServices = cepServices;
        }

        public async Task<GenericResponse<EnderecoResponse>> BuscarEndereco(string cep)
        {
            var endereco = await _cepServices.BuscarEndereco(cep);
            return _mapper.Map<GenericResponse<EnderecoResponse>>(endereco);
        }
    }
}
