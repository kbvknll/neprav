namespace Calculator.Data
{
    public class Agent
    {
        public Agent(string firstName, string lastName, int age, int group)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Group = group;
        }

        public Agent()
        {
            Id = "";
            FirstName = "";
            LastName = "";
            Age = 0;
            Group = 0;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Group { get; set; }
    }
}
