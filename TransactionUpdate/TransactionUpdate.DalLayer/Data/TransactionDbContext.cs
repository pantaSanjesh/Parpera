using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionUpdate.DalLayer.Model;

namespace TransactionUpdate.DalLayer.Data
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options ): base(options) 
        {
                
        }
        public DbSet<TransactionModel> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed static data
            modelBuilder.Entity<TransactionModel>().HasData(
               new TransactionModel { Id = 11, DateTime = "2020-09-08'T'16:34:23Z", Description = " Bank Deposit", Amount = 500.00, Status = "Completed" },
               new TransactionModel { Id = 10, DateTime = "2021-09-08'T'09:02:23Z", Description = "Transfer to James", Amount = -20.00, Status = "Pending" }
                // Add more static data as needed
            );
        }
    }
}
