using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id = 0, HowTo = "Break an egg", Line = "Have fun", Platform = "Mic and stage"},
                new Command{Id = 1, HowTo = "Paint a wall", Line = "Get a paint brush", Platform = "Your room"},
                new Command{Id = 2, HowTo = "Cut bread", Line = "Get a knife", Platform = "Cutting board"}
            };
            return commands;
        }
         
        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Break an egg", Line="Have gun", Platform="Mic and stage"};
        }
    }
}
