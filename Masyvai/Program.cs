using System;
using System.Globalization;
using System.Runtime;
namespace Masyvai
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // 1 uzduotis
            int[] masyvas = new int[6];
            Console.WriteLine($"Irasykite {masyvas.Length} skaicius");
            for(int i = 0; i < masyvas.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                masyvas[i] = int.Parse(Console.ReadLine());
            }
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            int teigiami = 0;
            int neigiami = 0;
            int nuliai = 0;

            bool lyginis = false;
            for (int i = 0; i < masyvas.Length; i++)
            {
                //max, min skaiciai
                if (masyvas[i] > max)
                {
                    max = masyvas[i];
                } else if (masyvas[i] < min)
                {
                    min = masyvas[i];
                };
                //teigiami, neigiami, nuliai
                if (masyvas[i] > 0)
                {
                    teigiami++;
                } else if (masyvas[i] < 0)
                {
                    neigiami++;
                } else
                {
                    nuliai++;
                };
                //lyginis skaicius
                if (masyvas[i] % 2 == 0)
                {
                    lyginis = true;
                }
            }
            Console.Write($"\nMasyve didziausias skaicius yra {max}, maziausias skaicius yra {min}. Masyve yra {teigiami} teigiamu, {neigiami} neigiamu bei {nuliai} nuliniu skaiciu. ");
            if (lyginis) 
            {
                Console.Write("Masyve yra lyginiu skaiciu.");
            }

            // 2 uzduotis
            Preke[] prekes = new Preke[5];
            Console.WriteLine("Pasirinkite preke:\n1. Sokoladas - 3 eur\n2. Sumustinis - 5 eur\n3. Tortas - 10 eur\n4. Pienas - 1 eur\n5. Saldainis - 0.5 eur\n6. Riesutai - 12 eur\n7. Mesa - 13 eur");
            for (int i = 0; i < prekes.Length; i++)
            {
                string preke = "";
                double kiekis = 0;
                double kaina = 0;
                Console.WriteLine("Pasirinkite preke");
                switch(int.Parse(Console.ReadLine()))
                {
                    case 1:
                        preke = "Sokoladas";
                        Console.WriteLine("Kiek vienetu sokolado noretumete?");
                        kiekis = double.Parse(Console.ReadLine());
                        kaina = 3;
                        break;
                    case 2:
                        preke = "Sumustinis";
                        Console.WriteLine("Kiek vienetu sumustiniu noretumete?");
                        kiekis = double.Parse(Console.ReadLine());
                        kaina = 5;
                        break;
                    case 3:
                        preke = "Tortas";
                        Console.WriteLine("Kiek vienetu tortu noretumete?");
                        kiekis = double.Parse(Console.ReadLine());
                        kaina = 10;
                        break;
                    case 4:
                        preke = "Pienas";
                        Console.WriteLine("Kiek vienetu pieno noretumete?");
                        kiekis = double.Parse(Console.ReadLine());
                        kaina = 1;
                        break;
                    case 5:
                        preke = "Saldainis";
                        Console.WriteLine("Kiek vienetu saldainiu noretumete?");
                        kiekis = double.Parse(Console.ReadLine());
                        kaina = 0.5;
                        break;
                    case 6:
                        preke = "Riesutai";
                        Console.WriteLine("Kiek vienetu riesutu noretumete?");
                        kiekis = double.Parse(Console.ReadLine());
                        kaina = 12;
                        break;
                    case 7:
                        preke = "Mesa";
                        Console.WriteLine("Kiek vienetu mesos noretumete?");
                        kiekis = double.Parse(Console.ReadLine());
                        kaina = 13;
                        break;
                }
                prekes[i] = new Preke(preke, kiekis, kaina);
            }
            double bendraSuma = 0;
            foreach (Preke  item in prekes)
            {
                 bendraSuma += item.BendraKaina();
                if (bendraSuma > 50)
                {
                    Console.WriteLine("Krepselio suma virsija 50");
                    break;
                }
            }

        }
    }
}
