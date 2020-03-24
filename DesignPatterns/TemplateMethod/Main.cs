using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>
    /// Classes com algorítimos parecidos podem ser substituída por templates. Preenchendo lacunas com classes concretas.
    /// </summary>
    public class Main
    {
        public Main()
        {
            Console.WriteLine("Template Method...");

            var test1 = new Website();
            test1.Run();

            var test2 = new IntranetWebSite();
            test2.Run();

            Console.ReadKey();
        }
    }
}
