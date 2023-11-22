using System;

namespace Uppgift_5._3
{
    class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Hur många tal vill du skriva in?");
                int antal = int.Parse(Console.ReadLine());
                int[] tal = new int[antal];
                Console.WriteLine($"Skriv in {antal} heltal");
                for (int i = 0; i < tal.Length; i++)
                {
                    tal[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Detta är de tal som du skrev in:");
                
                for (int i = 0;i < tal.Length; i++)
                {
                    Console.WriteLine($"Tal {i + 1}: {tal[i]}");
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("Du gav inte rätt input, försök igen");
                Main();
            }
        }
    }
}