using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class Website : TemplateTest
    {
        public override void Pesquisa()
        {
            Console.WriteLine("Fiz a pesquisa no website");
        }
    }
}
