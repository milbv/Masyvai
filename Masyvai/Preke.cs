using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai
{
    public class Preke
    {
        public string Pavadinimas { get; set; }
        public double Kaina { get; set; }
        public double Kiekis { get; set; }

        public Preke()
        {
            Pavadinimas = "";
        }
        public Preke(string pavadinimas, double kaina, double kiekis)
        {
            Pavadinimas = pavadinimas;
            Kaina = kaina;
            Kiekis = kiekis;
        }
        public double BendraKaina()
        {
            return Kaina * Kiekis;
        }
    }
}
