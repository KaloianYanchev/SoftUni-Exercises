using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int treatedPatients = 0;
            int unTreatedPatients = 0;
            int patientCapacity = 7;

            for(int i = 1; i <= n; i++)
            {
                int patients = int.Parse(Console.ReadLine());

                if (i % 3 == 0 && treatedPatients < unTreatedPatients)
                {
                    patientCapacity++;
                }


                if (patients > patientCapacity)
                {
                    treatedPatients += patientCapacity;
                    unTreatedPatients += patients - patientCapacity;
                }
                else
                {
                    treatedPatients += patients;
                }

            }

            Console.WriteLine($"Treated patients: {treatedPatients}.");
            Console.WriteLine($"Untreated patients: {unTreatedPatients}.");
            
        }
    }
}