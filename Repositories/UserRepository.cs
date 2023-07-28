using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebAPI_Wa.Models;

namespace WebAPI_Wa.Repositories
{
    public static class UserRepository
    {
        /// <summary>
        /// Favor quando for logar para pegar a autorização do token logar em um destes dois usuários
        /// para realizar os testes dos endpoints da API do e-commerce.
        /// </summary>
        /// <param name="username"></param>
        /// <param pass="password"></param>
        /// <returns></returns>
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() {id = 1, userName="wa_project", password="wa_project", role="company"},
                new() {id = 2, userName="alexssandro", password="alexssandro", role="dev"}
            };

            return users.FirstOrDefault(x => x.userName == username && x.password == password);
        }
    }
}
