using System.Collections.Generic;

namespace Task1.ClassChefInCSharp
{
    internal class Bowl
    {
        public Bowl()
        {
            this.BowlArr = new List<Vegetable>();
        }

        private List<Vegetable> BowlArr { get; set; }

        internal void Add(Vegetable vegetable)
        {
            this.BowlArr.Add(vegetable);
        }
    }
}