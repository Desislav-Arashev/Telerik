using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_after_10_Years
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());
            int age = (int)((DateTime.Now - BirthDate).TotalDays / 365.242199);
            Console.WriteLine("You are " + age + " years old.");
            Console.WriteLine("After ten years you will be " + (age + 10) + "years old");
        }
    }
}
