namespace DesignPatterns.Strategy
{
    public class Calculadora
    {
         private IOperacao operacao;

        public Calculadora(IOperacao operacao)
        {
            this.operacao = operacao;
        }

        public int Executa(int a, int b)
        {
            return this.operacao.Executa(a, b);
        }

       
    }
}