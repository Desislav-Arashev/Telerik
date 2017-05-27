namespace Task1.ClassChefInCSharp
{
    public class Chef
    {
        public void Cook()
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            Bowl bowl;

            this.Peel(potato);
            this.Peel(carrot);

            bowl = this.GetBowl();

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            return new Carrot();
        }

        private Potato GetPotato()
        {
            return new Potato();
        }

        private void Peel(Vegetable vegetable)
        {
            vegetable.Peeled = true;
        }

        private void Cut(Vegetable vegetable)
        {
            vegetable.Cutted = true;
        }
    }
}
