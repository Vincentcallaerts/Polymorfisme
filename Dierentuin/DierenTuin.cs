using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dierentuin
{
    class DierenTuin
    {
        List<Dier> diertjes = new List<Dier>();
        public void AddDier(Dier dier)
        {
            diertjes.Add(dier);
        }
        public void DeleteDier(int index)
        {
            diertjes.RemoveAt(index);
        }
        public void ClearDiertjes()
        {
            diertjes.Clear();
        }
        public void Zegt()
        {
            foreach (var item in diertjes)
            {
                item.Zegt();
            }
        }
        public void DierenGewichtGemiddelde()
        {
            double temp = 0;
            foreach (var item in diertjes)
            {
                temp += item.Gewicht;
            }
            Console.WriteLine(Math.Round(temp/diertjes.Count));
        }
        public void FilterPraat(Object obj)
        {
            if (obj is Schildpad)
            {
                for (int i = 0; i < diertjes.Count; i++)
                {
                    if (diertjes[i] is Schildpad)
                    {
                        diertjes[i].Zegt();
                    }
                }
            }
            else if (obj is Ooievaar)
            {
                for (int i = 0; i < diertjes.Count; i++)
                {
                    if (diertjes[i] is Ooievaar)
                    {
                        diertjes[i].Zegt();
                    }
                }
            }
            else if(obj is Octopus)
            {
                for (int i = 0; i < diertjes.Count; i++)
                {
                    if (diertjes[i] is Octopus)
                    {
                        diertjes[i].Zegt();
                    }
                }
            }
        }

    }
}
