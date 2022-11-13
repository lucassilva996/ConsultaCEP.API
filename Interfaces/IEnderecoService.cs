using ConsultaCEP.API.DTO;
using ConsultaCEP.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenerico<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
