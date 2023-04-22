using Practicing_SOLID_CSharp._5___DIP.Violação.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._5___DIP.Violação.Models
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
