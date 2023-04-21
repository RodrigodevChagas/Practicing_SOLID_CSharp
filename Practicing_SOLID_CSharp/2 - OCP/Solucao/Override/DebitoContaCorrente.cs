
namespace Practicing_SOLID_CSharp._2___OCP.Solucao.Override
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(string Valor, string NumeroDaConta) 
        {
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}
