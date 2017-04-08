using System;

namespace Task3.RefactorTheFollowing
{
    public class LoopRefactored
    {
        public static void PrintValue(int exprectedValue)
        {
            int[] values = new int[100];
            for (int i = 0; i < values.Length; i++)
            {
                if (i % 10 == 0 && values[i] == exprectedValue)
                {
                    Console.WriteLine("Value Found");
                    break;
                }

                Console.WriteLine(values[i]);
            }
        }
    }
}
