using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic
{
    class Manager
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        public void BeschrijfCards()
        {
            
            for (int i = 0; i < Cards.Count; i++)
            {
                if (Cards[i] is CreatureCard)
                {
                    Console.WriteLine($"Kaart {i} is een CreatureCard");
                }
                if (Cards[i] is SpellCard)
                {
                    Console.WriteLine($"Kaart {i} is een SpellCard");
                }
                if (Cards[i] is Land)
                {
                    Console.WriteLine($"Kaart {i} is een Land");
                }
                if (Cards[i] is Artifact)
                {
                    Console.WriteLine($"Kaart {i} is een Artifact");
                }
            }
            Console.ReadLine();
        }
    }

    public class Card
    {
        public int Cost { get; set; }

    }

    public class CreatureCard : Card
    {
        public int Health { get; set; }
        public int Attack { get; set; }
    }

    public class SpellCard : Card
    {
        
    }
    public class Land : Card
    {

    }
    public class Artifact : Card
    {

    }

}
