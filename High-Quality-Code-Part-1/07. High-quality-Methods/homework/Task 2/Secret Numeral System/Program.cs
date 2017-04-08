namespace Secret_Numeral_System
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(',').Select(x => x.Trim()).ToArray();
            var numsInBase7 = new BigInteger[inputArr.Length];
            BigInteger result = 1;

            ReplaceAllNumbers(inputArr, numsInBase7);

            result = SumAllNumbers(numsInBase7, result);

            Console.WriteLine(result);
        }

        private static BigInteger SumAllNumbers(BigInteger[] numsInBase7, BigInteger result)
        {
            foreach (var item in numsInBase7)
            {
                result *= item;
            }

            return result;
        }

        private static void ReplaceAllNumbers(string[] inputArr, BigInteger[] numsInBase7)
        {
            for (int i = 0; i < inputArr.Length; i++)
            {
                numsInBase7[i] = BaseNtoDec(ReplaceNameToDigit(inputArr[i]));
            }
        }

        private static BigInteger BaseNtoDec(string number)
        {
            BigInteger result = 0;
            foreach (char num in number)
            {
                result = (result * 8) + (num - '0');
            }

            return result;
        }

        private static string ReplaceNameToDigit(string names)
        {
            string[] dictionary = new string[] 
            {
                "hristo",
                "tosho", "pesho",
                "hristofor",
                "vlad",
                "haralampi",
                "zoro",
                "vladimir"
            };
            string[] dictionaryNumbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7" };
            for (int i = dictionary.Length - 1; i >= 0; i--)
            {
                names = names.Replace(dictionary[i], dictionaryNumbers[i]);
            }

            return names;
        }
    }
}
