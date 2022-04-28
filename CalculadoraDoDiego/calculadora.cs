using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDoDiego
{
   
        public abstract class calculadora
        {
            public virtual double num1 { get; set; }
            public virtual double num2 { get; set; }
            
            public abstract double calculo();

            
        }
}
