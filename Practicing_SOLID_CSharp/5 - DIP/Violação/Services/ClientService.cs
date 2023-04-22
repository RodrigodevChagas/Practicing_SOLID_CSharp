using Practicing_SOLID_CSharp._5___DIP.Violação.Models;
using Practicing_SOLID_CSharp._5___DIP.Violação.Repository;

namespace Practicing_SOLID_CSharp._5___DIP.Violação.Services
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
