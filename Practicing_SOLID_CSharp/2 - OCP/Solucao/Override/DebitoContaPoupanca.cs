
namespace Practicing_SOLID_CSharp._2___OCP.Solucao.Override
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(string Valor, string NumeroDaConta) 
        {
            // Valida Aniversário da Conta
            // Debita Conta Corrente
            return FormatarTransacao();
        }
    }
}
