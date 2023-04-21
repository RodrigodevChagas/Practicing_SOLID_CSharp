
namespace Practicing_SOLID_CSharp._2___OCP.Solucao.Override
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(string Valor, string NumeroDaConta) 
        {
            // Debita Conta Investimento
            // Isentar Taxas
            return FormatarTransacao();
        }
    }
}
