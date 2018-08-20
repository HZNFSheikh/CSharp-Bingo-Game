using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {

            //Player1 chooses their numbers
            List<int> arr = new List<int>();
            Console.WriteLine("Player 1 choose your numbers");


            for (int i = 0; i < 6; i++)
                arr.Add(int.Parse(Console.ReadLine()));

            Console.WriteLine(" Player 1 Your numbers are \n");

            foreach (int v in arr)
                Console.WriteLine("{0}\n", v);
            int[] playerNums = arr.ToArray();


            //Generate 99 random numbers to be called out
            Random randomNumber = new Random();

            int[] bingoNumber = Enumerable
                .Repeat(0, 99)
                .Select(i => randomNumber.Next(1, 99))
                .ToArray();

            Console.WriteLine(bingoNumber);

            foreach (var entry in bingoNumber)
            {
                Console.WriteLine("The chosen number is " + entry);
            }

            for (int i = 0; i < bingoNumber.Length; i++)
            {
                for (int j = 0; j < playerNums.Length; j++)
                {
                    if (bingoNumber[i] == playerNums[j])
                    {
                        Console.WriteLine(bingoNumber[i] + " is a match");
                    }
                }
            }


        }
    }
}
