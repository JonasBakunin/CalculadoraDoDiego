using System;

namespace CalculadoraDoDiego
{
    class Program
    {
        static void Main(string[] args)
        {
            
            calculadora conta;
            string tmp;
            

            conta = new soma();

            Console.WriteLine("Digite um número: ");
            tmp = Console.ReadLine();
            conta.num1 = int.Parse(tmp);

            Console.WriteLine("Digite mais um número: ");
            tmp = Console.ReadLine();
            conta.num2 = int.Parse(tmp);


            Console.WriteLine("Resultado é: " + conta.calculo());
        }

        //multiplicação loop
    }
}

