using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public class IntranetWebSite : TemplateTest
    {
        public override void Pesquisa()
        {
            Console.WriteLine("Intranet WebSite...");
        }
    }
}
