using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._2___OCP.Violacao
{
    public class DebitoConta
    {
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // Debita Conta Corrente
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // Valida Aniversário da Conta
                // Debita Conta Poupança
            }
        }
    }
}
