using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MadLib_Console
{
    class Program
    {
        static void Main(string[] args)
        {
           ConsoleUI ui = new ConsoleUI();
            ui.MainMenu();
        }
    }
}
