using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public class Soma : IOperacao
    {
        public int Executa(int a, int b)
        {
            return a + b;
        }
    }
}
