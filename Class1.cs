using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFun
{
    internal class Class1
    {
        public static int[] Roller(int rollnum)
        {
            int die1 = 0;
            int die2 = 0;
            int roll = 0;
            int[] counts = new int[11];
            for (int i = 0; i < rollnum; i++)
            {
                Random rnd = new Random();
                die1 = rnd.Next(1, 7);
                die2 = rnd.Next(1, 7);
                roll = die1 + die2;

                counts[roll - 2]++;
            }
            return counts;
        }
    }
}
