using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Calculator.Data
{
    public class Transaction
    {
        public Agent Agent { get; set; }
        public decimal Amount { get; set; }
        public Transaction(Agent agent, decimal amount)
        {
            Agent = agent;
            Amount = amount;
        }

        public Transaction()
        {
            Agent.Id = Guid.NewGuid().ToString();
            Agent.FirstName = "";
            Agent.LastName = "";
            Amount = 0;
        }
    }
}
