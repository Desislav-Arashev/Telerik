using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_a_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 1001; i++)
            {
                if (IsOdd(i))
                {
                    Console.Write(-i + ",");
                }
                else
                {
                    Console.Write(i + ",");
                }
            }
        }
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }
    }
}
