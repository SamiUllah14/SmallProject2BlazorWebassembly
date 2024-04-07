using Microsoft.EntityFrameworkCore;
using SmallProject2.Server.Models;
using System;
using System.Linq;

namespace SmallProject2.Server.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed data
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem { Id = 1, TaskName = "Complete project", IsCompleted = false },
                new TodoItem { Id = 2, TaskName = "Review code", IsCompleted = false }
                // Add more seed data as needed
            );
        }
    }
}
