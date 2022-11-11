using ConsultaCEP.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Interfaces
{
    public interface ICepServices
    {
        Task<GenericResponse<EnderecoResponse>> BuscarEndereco(string cep);
    }
}
