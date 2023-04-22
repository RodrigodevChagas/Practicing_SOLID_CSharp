using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._4___ISP.Solução.Interfaces
{
    internal interface ICadastroCliente
    {
        void EnviarEmail();
        void SalvarBanco();
        void ValidarDados();
        
    }
}
