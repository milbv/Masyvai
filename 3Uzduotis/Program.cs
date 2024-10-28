using System;
namespace Masyvai
{
    // 3 uzduotis
    public class Program
    {
        static void Main(string[] args)
        {
            Studentas[] studentai = [
                new Studentas("Josefas", [9, 2, 1]),
                new Studentas( "Jonas", [4, 4, 7]),
                new Studentas("Petras", [2, 2, 3]),
                new Studentas("Joana", [10, 10, 10])
                ]; 
            for (int i = 0; i < studentai.Length; i++)
            {
                if (studentai[i].Islaike())
                {
                    Console.WriteLine($"{studentai[i].Vardas} islaike");
                } else
                {
                    Console.WriteLine($"{studentai[i].Vardas} neislaike");
                }
            }
        }
    }
}
