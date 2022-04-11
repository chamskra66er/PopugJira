using Microsoft.EntityFrameworkCore;
using PopugJira.Data;
using PopugJira.Interfaces;
using PopugJira.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PopugJira.Services
{
    public class TaskService : ITask
    {
        private readonly ApplicationDbContext context;
        public TaskService(ApplicationDbContext context)
        { 
            this.context = context;
        }
        public async Task AddTask(Tasks task)
        {
            context.Add(task);
            await context.SaveChangesAsync();
        }

        public Tasks GetById(int id)
        {
            return context.TasksList.Where(x=>x.Id == id).
                Include(x=>x.userCreated).
                Include(x=>x.userExecute).FirstOrDefault();
        }

        public Task RemoveTask(Tasks task)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Tasks> TakList()
        {
            throw new System.NotImplementedException();
        }
    }
}
