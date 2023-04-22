using Practicing_SOLID_CSharp._5___DIP.Solução.Interfaces;
using Practicing_SOLID_CSharp._5___DIP.Solução.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._5___DIP.Solução.Models
{
    public class Client
    {
        private readonly ICPFService _cpfService;
        private readonly IEmailService _emailService;

        public Client(ICPFService cpfService, IEmailService emailService)
        {
            _cpfService = cpfService;
            _emailService = emailService;
        }

        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid() {
            return _cpfService.IsCPFValid(CPF) && _emailService.IsEmailValid(Email);
        }
    }
}
