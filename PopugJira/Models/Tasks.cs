using Microsoft.AspNetCore.Identity;
using System;

namespace PopugJira.Models
{
    public class Tasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public IdentityUser userCreated { get; set; }
        public IdentityUser userExecute { get; set; }
    }
}
