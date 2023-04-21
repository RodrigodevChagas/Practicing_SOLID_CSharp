using Practicing_SOLID_CSharp._1___SRP.Solução.Models;
using Practicing_SOLID_CSharp._1___SRP.Solução.Repository;

namespace Practicing_SOLID_CSharp._1___SRP.Solução.Services
{
    public class ClientService
    {
        public string AddClient(Client client) 
        {
            if (!client.IsValid())
                return "Dados Inválidos!";

            var repos = new ClientRepository();

            repos.AddClient(client);

            EmailService.SendEmail(client.Email);

            return "Client successfully registered!";
        }
    }
}
