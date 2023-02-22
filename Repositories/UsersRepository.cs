using ConsultaCEP.API.Model;
using System.Collections.Generic;
using System.Linq;

namespace ConsultaCEP.API.Repositories
{
    public class UsersRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();

            users.Add(new User
            {
                Id = 1,
                Username = "admin",
                Password = "123@",
                Role = "manager"
            });

            return users.Where(x => x.Username.ToLower() == username && x.Password == x.Password).First();
        }
    }
}
