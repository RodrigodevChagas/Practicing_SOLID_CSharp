using Practicing_SOLID_CSharp._5___DIP.Solução.Interfaces;
using Practicing_SOLID_CSharp._5___DIP.Solução.Models;

namespace Practicing_SOLID_CSharp._5___DIP.Solução.Services
{
    public class ClientService : IClientService
    {
        private readonly IEmailService emailService;
        private readonly IClientRepository clientRepository;

        public ClientService(IEmailService emailService, IClientRepository clientRepository)
        {
            this.emailService = emailService;
            this.clientRepository = clientRepository;
        }

        public string AddClient(Client client) 
        {
            if (!client.IsValid())
                return "Dados Inválidos!";

            clientRepository.AddClient(client);

            emailService.SendEmail(client.Email);

            return "Client successfully registered!";
        }
    }
}
