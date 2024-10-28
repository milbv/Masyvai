using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masyvai
{
    public class Studentas
    {
        public string Vardas { get; set; }
        public int[] Pazymiai { get; set; }

        public Studentas()
        {
        }
        public Studentas(string vardas, int[] pazymiai)
        {
            Vardas = vardas;
            Pazymiai = pazymiai;
        }
        public double Vidurkis()
        {
            return Pazymiai.Average();
        }
        public bool Islaike()
        {
            if (Vidurkis() > 5)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
