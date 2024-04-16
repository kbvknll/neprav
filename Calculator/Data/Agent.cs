namespace Calculator.Data
{
    public class Agent
    {
        public Agent(string firstName, string lastName, int age, int dogovor)
        {
            Id = Guid.NewGuid().ToString();
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Dogovor = dogovor;
        }

        public Agent()
        {
            Id = Guid.NewGuid().ToString();
            FirstName = "";
            LastName = "";
            Age = 0;
            Dogovor = 0;
        }

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Dogovor { get; set; }
    }
}
