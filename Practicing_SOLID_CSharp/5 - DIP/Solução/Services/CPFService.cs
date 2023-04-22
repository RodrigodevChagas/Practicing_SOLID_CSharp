using Practicing_SOLID_CSharp._5___DIP.Solução.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._5___DIP.Solução.Services
{
    public class CPFService : ICPFService
    {
        public bool IsCPFValid(string CPF)
        {
            return CPF.Length == 11;
        }
    }
}
