using System;
using System.Diagnostics;

namespace Compare_simple_Maths
{
    public class StartUp
    {
        private const int FirstInt = 2;
        private const int SecondInt = 3;

        private const long FirstLong = 2;
        private const long SecondLong = 3;

        private const float FirstFloat = 2;
        private const float SecondFloat = 3;

        private const double FirstDouble = 2;
        private const double SecondDouble = 3;

        private const decimal FirstDecimal = 2;
        private const decimal SecondDecimal = 3;

        private const int TimesToTestSameValue = 2;
        private const int NumberOfOperationsToPerform = 100000;

        private static int xInt = 0;
        private static float xFloat = 0;
        private static long xLong = 0;
        private static double xDouble = 0;
        private static decimal xDecimal = 0;
        private static Stopwatch stopwatch = new Stopwatch();

        public static void Main(string[] args)
        {
            TestAdd();
            TestSubstract();
            TestIncrement();
            TestMultiply();
            TestDivide();
        }

        private static void TestAdd()
        {
            Console.WriteLine("***********");
            Console.WriteLine("Test Add");
            Console.WriteLine("***********");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xInt = FirstInt + SecondInt;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Long");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xLong = FirstLong + SecondLong;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Float");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xFloat = FirstFloat + SecondFloat;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Double");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDouble = FirstDouble + SecondDouble;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Decimal");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDecimal = FirstDecimal + SecondDecimal;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        private static void TestSubstract()
        {
            Console.WriteLine();
            Console.WriteLine("***********");
            Console.WriteLine("Test Substract");
            Console.WriteLine("***********");
            Console.WriteLine("Int");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xInt = FirstInt - SecondInt;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Long");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xLong = FirstLong - SecondLong;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Float");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xFloat = FirstFloat - SecondFloat;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Double");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDouble = FirstDouble - SecondDouble;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Decimal");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDecimal = FirstDecimal - SecondDecimal;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        private static void TestIncrement()
        {
            Console.WriteLine();
            Console.WriteLine("***********");
            Console.WriteLine("Test Increment");
            Console.WriteLine("***********");
            Console.WriteLine("Int");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xInt++;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Long");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xLong++;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Float");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xFloat++;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Double");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDouble++;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Decimal");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDecimal++;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        private static void TestMultiply()
        {
            Console.WriteLine();
            Console.WriteLine("***********");
            Console.WriteLine("Test Multiply");
            Console.WriteLine("***********");
            Console.WriteLine("Int");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xInt = FirstInt * SecondInt;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Long");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xLong = FirstLong * SecondLong;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Float");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xFloat = FirstFloat * SecondFloat;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Double");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDouble = FirstDouble * SecondDouble;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Decimal");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDecimal = FirstDecimal * SecondDecimal;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }

        private static void TestDivide()
        {
            Console.WriteLine();
            Console.WriteLine("***********");
            Console.WriteLine("Test Divide");
            Console.WriteLine("***********");
            Console.WriteLine("Int");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xInt = FirstInt / SecondInt;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Long");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xLong = FirstLong / SecondLong;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Float");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xFloat = FirstFloat / SecondFloat;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Double");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDouble = FirstDouble / SecondDouble;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }

            Console.WriteLine("Decimal");

            for (int j = 0; j < TimesToTestSameValue; j++)
            {
                stopwatch.Start();
                for (int i = 0; i < NumberOfOperationsToPerform; i++)
                {
                    xDecimal = FirstDecimal / SecondDecimal;
                }

                stopwatch.Stop();
                Console.WriteLine("Time Elapsed: " + stopwatch.Elapsed);
                stopwatch.Reset();
            }
        }
    }
}
