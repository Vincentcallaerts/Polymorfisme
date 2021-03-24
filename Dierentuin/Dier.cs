using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    abstract class Dier
    {
        protected double gewicht;
        public string Naam { get; set; }
        public double Gewicht
        {
            get { return gewicht; }
            set { gewicht = value; }
        }

        public abstract void Zegt();
        
    }
}
