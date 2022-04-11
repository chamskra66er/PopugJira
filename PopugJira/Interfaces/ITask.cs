using PopugJira.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PopugJira.Interfaces
{
    public interface ITask
    {
        Task AddTask(Tasks task);
        Task RemoveTask(Tasks task);
        IEnumerable<Tasks> TakList();
        Tasks GetById(int id);
    }
}
