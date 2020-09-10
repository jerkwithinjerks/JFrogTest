namespace JFrogTest.Client
{
    public class PersonClient
    {
        public Person GetPersonByName(string name)
        {
            if(name == "Jimmy Lee")
                return new Person
                {
                    Name = "Jimmy Lee",
                    Age = 99
                };
            return null;
        }
    }
}
