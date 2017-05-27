using System;
using System.Diagnostics;

namespace Compare_advanced_Math
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var repeats = 10000000;
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Square root");

            float xFloat = 5;
            double xDouble = 5;
            decimal xDecimal = 5;

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Sqrt(xFloat);
            }

            stopwatch.Stop();
            Console.WriteLine("Float:   " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Sqrt(xDouble);
            }

            stopwatch.Stop();
            Console.WriteLine("Double:  " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Sqrt((double)xDecimal);
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine("------------------");
            Console.WriteLine("Natural logarithm");

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Log(xFloat);
            }

            stopwatch.Stop();
            Console.WriteLine("Float:   " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Log(xDouble);
            }

            stopwatch.Stop();
            Console.WriteLine("Double:  " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Log((double)xDecimal);
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);
            stopwatch.Reset();

            Console.WriteLine("------------------");
            Console.WriteLine("Sinus");

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Sin(xFloat);
            }

            stopwatch.Stop();
            Console.WriteLine("Float:   " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Sin(xDouble);
            }

            stopwatch.Stop();
            Console.WriteLine("Double:  " + stopwatch.Elapsed);
            stopwatch.Reset();

            stopwatch.Start();
            for (int i = 0; i < repeats; i++)
            {
                Math.Sin((double)xDecimal);
            }

            stopwatch.Stop();
            Console.WriteLine("Decimal: " + stopwatch.Elapsed);
            stopwatch.Reset();
        }
    }
}
