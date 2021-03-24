using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();

            manager.AddCard(new SpellCard());
            manager.AddCard(new SpellCard());
            manager.AddCard(new CreatureCard());
            manager.AddCard(new SpellCard());
            manager.AddCard(new SpellCard());
            manager.AddCard(new Artifact());
            manager.AddCard(new Land());
            manager.AddCard(new CreatureCard());
            manager.AddCard(new CreatureCard());

            manager.BeschrijfCards();

        }
    }
}
