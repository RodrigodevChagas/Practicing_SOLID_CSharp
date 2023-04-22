using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._3___LSP.Solução
{
    internal class Paralelogramo
    {
        public Paralelogramo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; set; }
        public double Largura { get; set; }
        public double Area { get { return Altura * Largura; } }
    }
}
