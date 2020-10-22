using System.Collections.Generic;
using commander.Models;

namespace commander.Data
{
    public interface ICommanderRepo
    {
         IEnumerable<Command> GetAppCommands();
         Command GetCommandById(int id);
    }
}