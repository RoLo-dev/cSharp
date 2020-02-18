using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAccounts
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) {}

        public DbSet<User> Users {get;set;}
        public DbSet<Transaction> Transactions {get;set;}
    }
}