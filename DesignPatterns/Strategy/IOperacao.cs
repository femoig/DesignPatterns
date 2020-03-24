using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Strategy
{
    public interface IOperacao
    {
        int Executa(int a, int b);
    }
}
