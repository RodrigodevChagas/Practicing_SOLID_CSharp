using Practicing_SOLID_CSharp._1___SRP.Solução.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._1___SRP.Solução.Models
{
    public class Client
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CPF { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool IsValid() {
            return CPFService.IsCPFValid(CPF) && EmailService.IsEmailValid(Email);
        }
    }
}
