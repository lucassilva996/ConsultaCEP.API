using ConsultaCEP.API.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsultaCEP.API.Service
{
    public class CepServices
    {
        static readonly HttpClient client = new HttpClient();
        public static async Task<string> GetEnderecoViaCEP(int cep, string type)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"https://viacep.com.br/ws/{cep}/{type}/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
    
                return responseBody;
            }
            catch(Exception ex)
            {
                throw new CepExceptionsLib(ex.Message);
            }
        }
    }
}
