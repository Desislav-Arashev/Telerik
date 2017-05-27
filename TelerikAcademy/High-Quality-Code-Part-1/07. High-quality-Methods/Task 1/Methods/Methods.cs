using System;

namespace Methods
{
    public class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            bool noPositiveSides = a <= 0 || b <= 0 || c <= 0;
            bool sumOfTwoSidesIsLargerThanThirdSide = a + b > c && a + c > b && b + c > a;
            if (noPositiveSides)
            {
                throw new ArgumentException("Sides should be positive.");
            }
            if (!sumOfTwoSidesIsLargerThanThirdSide)
            {
                throw new ArgumentException("");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        public static string NumberToStringDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
            }

            throw new ArgumentException("Invalid number!");
        }

        public static int FindMax(params int[] elements)
        {
            int maxElement = elements[0];
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("Cannot be null or empty.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        internal static void PrintNumberWithPrecision(double number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        internal static void PrintNumberAsPercentage(double number)
        {
            {
                Console.WriteLine("{0:p0}", number);
            }
        }

        internal static void PrintNumberAlignedRight(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static double CalcDistance(
            double firstPointX,
            double firstPointY,
            double secondPointX,
            double secondPointY)
        {
            double distance = Math.Sqrt(((secondPointX - firstPointX) * (secondPointX - firstPointX)) + 
                ((secondPointY - firstPointY) * (secondPointY - firstPointY)));
            return distance;
        }

        internal static bool IsLineHorizontal(double firstPointY, double secondPointY)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointY - secondPointY) < AcceptableDifference;
        }

        internal static bool IsLineVertical(double firstPointX, double secondPointX)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(firstPointX - secondPointX) < AcceptableDifference;
        }

        public static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToStringDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintNumberWithPrecision(1.3);
            PrintNumberAsPercentage(0.75);
            PrintNumberAlignedRight(2.30);

            bool horizontal = Methods.IsLineHorizontal(-1, 2.5);
            bool vertical = Methods.IsLineVertical(3, 3);
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);
            
            Student peter = new Student("Ivan", "Georgiev", new DateTime(1980, 3, 12), "From Burgas");
            Student stella = new Student("Stella", "Markova", new DateTime(1995, 5, 3), "From Sofia, ps, high results");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
