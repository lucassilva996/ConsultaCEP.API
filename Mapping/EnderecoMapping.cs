using AutoMapper;
using ConsultaCEP.API.DTO;
using ConsultaCEP.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Mapping
{
    public class EnderecoMapping : Profile
    {
        public EnderecoMapping()
        {
            CreateMap(typeof(ResponseGenerico<>), typeof(ResponseGenerico<>));
            CreateMap<EnderecoResponse, EnderecoModel>();
            CreateMap<EnderecoModel, EnderecoResponse>();
        }
    }
}
