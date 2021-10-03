using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sololearn_LIsts_and_BitArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPlayers = Convert.ToInt32(Console.ReadLine());

            List<int> scores = new List<int>();
            int count = 0;
            while (count < numOfPlayers)
            {
                int score = Convert.ToInt32(Console.ReadLine());
                //your code goes here
                count++;
                scores.Add(score);
            }
            scores.Sort();

            foreach (var item in scores)
            {
                Console.Write(item + " ");
            }
        }
    }
}
