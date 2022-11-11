using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ConsultaCEP.API.DTO
{
    public class GenericResponse<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T DadosRetorno { get; set; }
        public ExpandoObject ErroRetorno { get; set; }
    }
}
