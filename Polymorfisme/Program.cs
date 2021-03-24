using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon derp = new Pokemon(5,5,5,5,5,5,1,"Bulbasaur","Grrrrrrras");
            Pokemon meerderp = new Pokemon(5, 5, 5, 5, 5, 5, 1, "Bulbasaur", "Grrrrrrras");
            Console.WriteLine(derp.Equals(meerderp));
            Console.ReadLine();
        }
    }
}
