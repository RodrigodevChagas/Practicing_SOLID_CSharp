using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing_SOLID_CSharp._3___LSP.Solução
{
    internal class Quadrado : Paralelogramo
    {
        public Quadrado(double altura, double largura) 
            : base(altura, largura)
        {
            if (altura != largura)
                throw new ArgumentException("Altura e largura de um quadrado devem ser iguais.");
        }
    }
}
