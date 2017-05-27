namespace Task2.MethodPrintStatisticsinCSharp
{
    public class StartUp
    {
        public static void Main()
        {
            var printer = new Printer();
            var array = new double[5]
            {
                22.5,
                66,
                11,
                1,
                6
            };
            printer.PrintStatisticsOfArray(array, 5);
        }
    }
}
