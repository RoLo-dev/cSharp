using System;
using Microsoft.EntityFrameworkCore;

namespace LogReg.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
    }
}