using ConsultaCEP.API.DTO;
using ConsultaCEP.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Interfaces
{
    public interface IRestService
    {
        Task<ResponseGenerico<EnderecoModel>> BuscarEnderecoPorCEP(string cep);

    }
}
