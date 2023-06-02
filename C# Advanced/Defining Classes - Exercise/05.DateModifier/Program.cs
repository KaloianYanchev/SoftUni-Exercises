using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();

            int differenceInDays = Math.Abs(DateModifier.GetDifference(startDate, endDate));

            Console.WriteLine(differenceInDays);

            //Console.WriteLine(DateModifier.GetDifference(startDate, endDate));
        }
    }
}