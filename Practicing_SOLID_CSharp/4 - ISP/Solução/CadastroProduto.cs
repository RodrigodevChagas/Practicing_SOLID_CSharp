using Practicing_SOLID_CSharp._4___ISP.Solução.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._4___ISP.Solução
{
    internal class CadastroProduto : ICadastroProduto
    {
        public void SalvarBanco()
        {
            //Salvo no banco.
        }

        public void ValidarDados()
        {
            //Valido os dados.
        }
    }
}
