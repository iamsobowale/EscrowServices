using EscrowServices.Models;
using Microsoft.EntityFrameworkCore;

namespace EscrowServices.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Traders> Traders { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Dispute> Disputes { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<TradersTransaction> TradersTransactions { get; set; }
    }
}