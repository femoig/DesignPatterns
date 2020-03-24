using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.TemplateMethod
{
    public abstract class TemplateTest
    {

        // The 'Template Method' 
        public void Run()
        {
            Login();
            Pesquisa();
            Logout();
        }

        public virtual void Login()
        {
            Console.WriteLine("Login...");
        }

        public abstract void Pesquisa();
        public virtual void Logout()
        {
            Console.WriteLine("Logout...");
            Console.WriteLine("----------------------------------");
        }
    }
}
