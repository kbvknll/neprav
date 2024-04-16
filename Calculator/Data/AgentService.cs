using Calculator.Pages;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calculator.Data
{
    public class AgentService
    {
        public List<Agent> Agents = new List<Agent>()
        {
            new Agent("Ivan", "Ivanov", 18, 221),
            new Agent("Ivan", "Petrov", 19, 321),
            new Agent("Ivan", "Barinov", 18, 221),
            new Agent("Ivan", "Shakirov", 18, 221),
            new Agent("Ivan", "Elizarov", 19, 321),
            new Agent("Ivan", "Skretov", 18, 221)
        };

        public Task<List<Agent>> GetAgentsAsync()
        {
            // В реальном приложении вы бы запрашивали агентов из базы данных асинхронно.
            // Для примера возвращаем асинхронно список агентов.
            return Task.FromResult(Agents);
        }

        // Метод для добавления нового агента.
        public Task AddAgentAsync(Agent agent)
        {
            // В реальном приложении вы бы добавляли агента в базу данных асинхронно.
            // Для примера добавляем агента в список агентов.
            Agents.Add(agent);
            return Task.CompletedTask;
        }
    }
}