namespace Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] temperaturos = new int[7];
            int tempSuma = 0;
            int min = Int32.MaxValue;
            int max = Int32.MinValue;
            for(int i = 0; i < temperaturos.Length; i++)
            {
                Console.Write((i + 1) +". ");
                temperaturos[i] = int.Parse(Console.ReadLine());

                if (temperaturos[i] > max)
                {
                    max = temperaturos[i];
                } else if (temperaturos[i] < min){
                    min = temperaturos[i];
                }
            }
            foreach (int temperatura in temperaturos)
            {
                tempSuma += temperatura;
            }
            if (tempSuma / temperaturos.Length < 10)
            {
                Console.WriteLine("Temperaturos vidurkis yra mazesnis nei 10");
            }
            Console.WriteLine($"Maksimali temperatura - {max}, minimali temperatura - {min}");
        }
    }
}
