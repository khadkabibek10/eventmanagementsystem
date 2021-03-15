using System;
using EventManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Event> Event { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Location> Location { get; set; }

    }
}
