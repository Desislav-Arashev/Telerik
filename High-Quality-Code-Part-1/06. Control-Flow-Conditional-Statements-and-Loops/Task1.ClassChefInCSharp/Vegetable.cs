namespace Task1.ClassChefInCSharp
{
    internal class Vegetable
    {
        public Vegetable()
        {
            this.Peeled = false;
            this.Cutted = false;
        }

        public bool Peeled { get; set; }

        public bool Cutted { get; set; }
    }
}