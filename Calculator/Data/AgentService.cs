namespace Calculator.Data
{
    public class AgentService
    {
        private List<Agent> Agents = new List<Agent>()
        {
            new Agent("Ivan", "Ivanov", 18, 221),
            new Agent("Ivan", "Petrov", 19, 321),
            new Agent("Ivan", "Barinov", 18, 221),
            new Agent("Ivan", "Shakirov", 18, 221),
            new Agent("Ivan", "Elizarov", 19, 321),
            new Agent("Ivan", "Skretov", 18, 221)
        };

        private List<Transaction> Transactions;

        public AgentService()
        {
            Transactions = new List<Transaction>()
            {
                new Transaction(Agents.First(a => a.FirstName == "Ivan" && a.LastName == "Ivanov"), -1000),
                new Transaction(Agents.First(a => a.FirstName == "Ivan" && a.LastName == "Petrov"), +1000),
                new Transaction(Agents.First(a => a.FirstName == "Ivan" && a.LastName == "Barinov"), +2000),
                new Transaction(Agents.First(a => a.FirstName == "Ivan" && a.LastName == "Shakirov"), -2000),
                new Transaction(Agents.First(a => a.FirstName == "Ivan" && a.LastName == "Elizarov"), +2000),
                new Transaction(Agents.First(a => a.FirstName == "Ivan" && a.LastName == "Skretov"), -3000),
            };
        }


        public Task<List<Agent>> GetAgentsAsync()
        {
            return Task.FromResult(Agents);
        }

        public Task AddAgentAsync(Agent agent)
        {
            Agents.Add(agent);
            return Task.CompletedTask;
        }

        public Task<List<Transaction>> GetTransactionsAsync()
        {
            return Task.FromResult(Transactions);
        }

        public Task AddTransactionAsync(Agent agent, decimal amount)
        {
            Transactions.Add(new Transaction(agent, amount));
            return Task.CompletedTask;
        }

        public async Task<decimal> GetAgentSumInDollarsAsync(string agentId)
        {
            decimal sum = Transactions
                .Where(t => t.Agent.Id == agentId)
                .Sum(t => t.Amount);
            return sum;
        }
    }
}