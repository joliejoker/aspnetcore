using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle & pan" },
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "knife & chopping board" },
                new Command { Id = 2, HowTo = "Make a cup of tea", Line = "Place teabag in cup", Platform = "kettle & cup" }
            };

            return commands;
        }

        public Command GetCommandbyId(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "kettle & pan" };
        }
    }
}