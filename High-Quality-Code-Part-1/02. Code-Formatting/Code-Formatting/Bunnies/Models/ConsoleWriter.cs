using Code_Formatting.Contracts;
using System;

namespace Code_Formatting.Models
{
    public class ConsoleWriter : IWritable
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
