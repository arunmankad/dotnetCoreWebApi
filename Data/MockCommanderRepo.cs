using System.Collections.Generic;
using commander.Models;

namespace commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="How to boil an egg", Line="Boil water", Platform="kettle & Pan"},
                new Command{Id=1, HowTo="How to make ommlet", Line="Egg", Platform="Pan"},
                new Command{Id=2, HowTo="How to boil an Maggie", Line="Boil water & maggie", Platform="Sauce Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="How to boil an egg", Line="Boil water", Platform="kettle & Pan"};
        }
    }
}