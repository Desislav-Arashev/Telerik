using System;

namespace Task2.MethodPrintStatisticsinCSharp
{
    public class Printer
    {
        public void PrintStatisticsOfArray(double[] arr, int numbersCount)
        {
            this.CheckEndIndex(numbersCount, arr);
            this.PrintMaxNumberFromArray(arr, numbersCount);
            this.PrintMinNumberFromArray(arr, numbersCount);
            this.PrintAverageNumberFromArray(arr, numbersCount);
        }

        private void CheckEndIndex(int endIndex, double[] arr)
        {
            if (endIndex > arr.Length || endIndex <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid end number");
            }
        }

        private void PrintMaxNumberFromArray(double[] arr, int numbersCount)
        {
            this.CheckEndIndex(numbersCount, arr);
            double max = double.MinValue;
            for (int i = 0; i < numbersCount; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            this.PrintValue(max);
        }

        private void PrintMinNumberFromArray(double[] arr, int numbersCount)
        {
            this.CheckEndIndex(numbersCount, arr);
            double min = double.MaxValue;
            for (int i = 0; i < numbersCount; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            this.PrintValue(min);
        }

        private void PrintAverageNumberFromArray(double[] arr, int numbersCount)
        {
            this.CheckEndIndex(numbersCount, arr);
            double sum = 0;
            double average = 0;
            for (int i = 0; i < numbersCount; i++)
            {
                sum += arr[i];
            }

            average = sum / numbersCount;
            this.PrintValue(average);
        }

        private void PrintValue(double value)
        {
            Console.WriteLine(value);
        }
    }
}
