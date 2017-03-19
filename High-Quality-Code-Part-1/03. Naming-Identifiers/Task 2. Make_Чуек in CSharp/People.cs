namespace MakePeople
{
    public class People
    {
        public Gender Gender { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public void ConfigurePerson(int age)
        {
            People person = new People();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Man;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Woman;
            }
        }
    }
}
