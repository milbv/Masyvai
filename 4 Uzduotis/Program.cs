namespace Masyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produktas[] produktai = [
                new Produktas("Pelekautai", 3.23m, 20),
                new Produktas("Zoliapjove", 200.3m, 1),
                new Produktas("Puodelis", 1m, 0),
                new Produktas("Juosta", 20m, 50),
                new Produktas("Rastas", 2.2m, 1)
            ];

            for (int i = 0; i < produktai.Length; i++)
            {
                if (produktai[i].YraSandelyje() && produktai[i].Kaina < 10m)
                {
                    Console.WriteLine(produktai[i].Pavadinimas);
                }
            }
        }
    }
}
