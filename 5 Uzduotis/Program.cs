namespace Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] skaiciai = new int[10];
            int[] dideliSkaiciai = new int[10];
            int neigiamiSkaiciai = 0;
            Console.WriteLine("Iveskite skaicius:");
            for (int i = 0; i < skaiciai.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                skaiciai[i] = int.Parse(Console.ReadLine());
                if (skaiciai[i] < 0)
                {
                    neigiamiSkaiciai++;
                }
                else if (skaiciai[i] > 20)
                {
                    dideliSkaiciai[i] = skaiciai[i];
                }
            }
            Console.WriteLine("Skaiciu, didesniu uz 20 masyvas");
            Console.Write("[");
            for ( int i = 0; i < dideliSkaiciai.Length; i++)
            {
                Console.Write(dideliSkaiciai[i] + ", ");
            }
            Console.WriteLine("]");
            Console.WriteLine("Neigiamu skaiciu skaicius " + neigiamiSkaiciai);

        }
    }
}
