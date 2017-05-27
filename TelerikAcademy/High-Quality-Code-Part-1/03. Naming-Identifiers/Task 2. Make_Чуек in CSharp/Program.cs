using System;

namespace MakePeople
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var person = new People();
            person.Age = 22;
            person.ConfigurePerson(3);
            Console.WriteLine(person.Gender);
        }
    }
}
