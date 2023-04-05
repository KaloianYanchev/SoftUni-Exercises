using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            int change = Convert.ToInt32(input * 100);
            double changeReturned = 0;
            int coin1 = 0;
            int coin2 = 0;
            int coin5 = 0;
            int coin10 = 0;
            int coin20 = 0;
            int coin50 = 0;
            int coin100 = 0;
            int coin200 = 0;

            int coinCount = 0;

            while (change >= changeReturned)
            {
                if (change % 200 >= 0)
                {
                    coin200 = change / 200;
                    change = change % 200;
                    changeReturned += coin200 * 200;
                }
                if (change % 100 >= 0)
                {
                    coin100 = change / 100;
                    change = change % 100;
                    changeReturned += coin100 * 100;
                }
                if (change % 50 >= 0)
                {
                    coin50 = change / 50;
                    change = change % 50;
                    changeReturned += coin50 * 50;
                }
                if (change % 20 >= 0)
                {
                    coin20 = change / 20;
                    change = change % 20;
                    changeReturned += coin20 * 20;
                }
                if (change % 10 >= 0)
                {
                    coin10 = change / 10;
                    change = change % 10;
                    changeReturned += coin10 * 20;
                }
                if (change % 5 >= 0)
                {
                    coin5 = change / 5;
                    change = change % 5;
                    changeReturned += coin5 * 5;
                }
                if (change % 2 >= 0)
                {
                    coin2 = change / 2;
                    change = change % 2;
                    changeReturned += coin2 * 2;
                }
                if (change % 1 >= 0)
                {
                    coin1 = change / 1;
                    change = change % 1;
                    changeReturned += coin1 * 1;
                    break;
            
                }


            }

            Console.WriteLine(coin1 + coin2 + coin5 + coin10 + coin20 + coin50 + coin100 + coin200);


        }
    }
}  
