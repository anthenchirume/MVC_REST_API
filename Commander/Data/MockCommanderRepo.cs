using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppComands()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommandById(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}