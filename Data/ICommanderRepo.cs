using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandbyId(int id);
    }
}