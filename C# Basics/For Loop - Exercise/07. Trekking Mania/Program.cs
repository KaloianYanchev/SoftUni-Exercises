using System;

namespace _06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int musala = 0;
            int monblan = 0;
            int kalimandjaro = 0;
            int k2 = 0;
            int everest = 0;
            double totalClimbers = 0;


            for (int i = 0; i < n; i++)
            {
                int numberOfClimbers = int.Parse(Console.ReadLine());
                totalClimbers += numberOfClimbers;

                if (numberOfClimbers <= 5)
                {
                    musala += numberOfClimbers;
                }
                else if (numberOfClimbers <= 12)
                {
                    monblan += numberOfClimbers;
                }
                else if (numberOfClimbers <= 25)
                {
                    kalimandjaro += numberOfClimbers;
                }
                else if (numberOfClimbers <= 40)
                {
                    k2 += numberOfClimbers;
                }
                else if (numberOfClimbers >= 41)
                {
                    everest += numberOfClimbers;
                }
            }

            Console.WriteLine($"{musala / totalClimbers * 100:f2}%");
            Console.WriteLine($"{monblan / totalClimbers * 100:f2}%");
            Console.WriteLine($"{kalimandjaro / totalClimbers * 100:f2}%");
            Console.WriteLine($"{k2 / totalClimbers * 100:f2}%");
            Console.WriteLine($"{everest / totalClimbers * 100:f2}%");


        }
    }
}