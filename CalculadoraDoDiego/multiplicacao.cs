using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDoDiego
{
    internal class multiplicacao : calculadora
    {
        public override double calculo()
        {
            return num1 * num2;
        }
    }
}
