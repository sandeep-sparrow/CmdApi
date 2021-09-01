using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using CmdApi.Models;

namespace CmdApi.DAL{
    public class CommandDbContext : DbContext{
        public CommandDbContext(DbContextOptions<CommandDbContext> options) : base(options)
        {
            
        }

        public DbSet<Command> CommandItems {get; set;}
    }
}