using Commander.Data;
using Commander.Models;

namespace Commander.data 
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command> 
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Plataform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Plataform = "Knife & Chopping board" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Plataform = "Kettle & Cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Plataform = "Kettle & Pan" };
        }
    }
}