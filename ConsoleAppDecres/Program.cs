using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDecres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 100;
            while(cont > 0)
            {
                Console.WriteLine(cont);
                cont--;
            }
            Console.ReadKey();
        }
    }
}
