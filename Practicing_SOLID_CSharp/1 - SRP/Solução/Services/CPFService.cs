using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._1___SRP.Solução.Services
{
    public static class CPFService
    {
        public static bool IsCPFValid(string CPF)
        {
            return CPF.Length == 11;
        }
    }
}
