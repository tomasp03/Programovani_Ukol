using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgUkol
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Heslo heslo = new Heslo();
            Prevodnik prevodnik = new Prevodnik(10000, 2, 8);
            Console.ReadLine();
        }
    }
}
