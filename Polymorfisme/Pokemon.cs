using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfisme
{
    class Pokemon
    {
        
        public Pokemon(int hp_Base, int attack_Base, int defense_Base, int specialAttack_Base, int specialDefence_Base, int speed_Base, int index, string name, string type) 
        {
            Hp_Base = hp_Base;
            Attack_Base = attack_Base;
            Defence_Base = defense_Base;
            SpecialAttack_Base = specialAttack_Base;
            SpecialDefence_Base = specialDefence_Base;
            Speed_Base = speed_Base;
            Name = name;
            Type = type;
            Random random = new Random();
            Level = random.Next(1,100);
        
        }
        public int Hp_Base { get; set; }
        public int Attack_Base { get; set; }
        public int Defence_Base { get; set; }
        public int SpecialAttack_Base { get; set; }
        public int SpecialDefence_Base { get; set; }
        public int Speed_Base { get; set; }
        public int Index { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        private int level;
        public int Level
        {
            get { return level; }
            private set { level = value; }
        }

        public int Hp_Full
        {
            get { return ((Hp_Base + 50)*Level)+10; }
            
        }
        public int Attack_Full
        {
            get { return ((Attack_Base + 50) * Level) + 10; }

        }
        public int Defence_Full
        {
            get { return ((Defence_Base + 50) * Level) + 10; }

        }
        public int SpecialAttack_Full
        {
            get { return ((SpecialAttack_Base + 50) * Level) + 10; }

        }
        public int SpecialDefense_Full
        {
            get { return ((SpecialDefence_Base + 50) * Level) + 10; }

        }
        public int Speed_Full
        {
            get { return ((Speed_Base + 50) * Level) + 10; }

        }


        public void VerhoogLevel()
        {
            if (Level != 100)
            {
                Level++;
            }
            
        }
        public int Totaal()
        {
            return Hp_Base + Attack_Base + Defence_Base + SpecialAttack_Base + SpecialDefence_Base + Speed_Base;
        }
        public double Average()
        {
            double temp = Convert.ToDouble(Totaal());
            return  temp/6;
        }

        public void ShowInfo() 
        {
            Console.WriteLine($"Naam: {Name} (Level {Level})");
            Console.WriteLine($"Base stats:\n\tHp: {Hp_Base}\n\tAttack: {Attack_Base}\n\tDefence: {Defence_Base}\n\tSpecial Attack: {SpecialAttack_Base}\n\tSpecial Defence: {SpecialDefence_Base}\n\tSpeed: {Speed_Base}");
            Console.WriteLine($"Full stats:\n\tHp: {Hp_Full}\n\tAttack: {Attack_Full}\n\tDefence: {Defence_Full}\n\tSpecial Attack: {SpecialAttack_Full}\n\tSpecial Defence: {SpecialDefense_Full}\n\tSpeed: {Speed_Full}");
            Console.WriteLine();
        }
        public override bool Equals(object obj)
        {
            Pokemon temp = (Pokemon)obj;
            if (temp.Totaal() == this.Totaal() && temp.Name == this.Name && temp.Level == this.Level )
            {
                return true;
            }
            return false;
        }

    }

}
