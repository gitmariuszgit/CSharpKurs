using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ///zmiana dla przykladu
            Console.WriteLine("Witam wszystkich i Ciebie {0}", args[0]);
            int x;
            bool wynik= int.TryParse(Console.ReadLine(), out x);
            Console.ReadKey();
        }
    }
}