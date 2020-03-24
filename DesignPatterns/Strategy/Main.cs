using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class Main
    {
        public Main()
        {
            Console.WriteLine("App start!");

            IOperacao soma = new Soma();

            Calculadora calculadora = new Calculadora(soma);
            int r1 = calculadora.Executa(2, 5);

            calculadora = new Calculadora(new Subtracao());
            int r2 = calculadora.Executa(10, 5);

            Console.WriteLine($"Resultado da soma é: {r1}");
            Console.WriteLine($"Resultado da sub é: {r2}");
            Console.ReadKey();
        }
    }
}
