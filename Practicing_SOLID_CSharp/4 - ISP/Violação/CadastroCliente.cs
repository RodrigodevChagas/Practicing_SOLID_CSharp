using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._4___ISP.Violação
{
    internal class CadastroCliente : ICadastro
    {
        public void EnviarEmail()
        {
            //Envia email
        }

        public void SalvarBanco()
        {
            //salva no banco
        }

        public void ValidarDados()
        {
            //Valida dados
        }
    }
}
