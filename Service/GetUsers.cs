using ConsultaCEP.API.Interfaces;
using ConsultaCEP.API.Model;
using ConsultaCEP.API.Repositories;
using System.Collections.Generic;

namespace ConsultaCEP.API.Service
{
    public class GetUsers : IUsers
    {
        public string GetAllUsers()
        {
            return "Tudo ok";
        }
    }
}
