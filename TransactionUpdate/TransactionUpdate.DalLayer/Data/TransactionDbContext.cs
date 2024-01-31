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
           
               new TransactionModel { Id = 11, DateTime = "2020-09-08'T'16:34:23Z", Description = "Bank Deposit", Amount = 500.00, Status = "Completed" },
               new TransactionModel { Id = 10, DateTime = "2020-09-08'T'09:02:23Z", Description = "Transfer to James", Amount = -20.00, Status = "Pending" },
               new TransactionModel { Id = 9, DateTime = "2020-09-07'T'21:52:23Z", Description = "ATM withdrawal", Amount = -20.00, Status = "Completed" },
               new TransactionModel { Id = 8, DateTime = "2020-09-06'T'10:32:23Z", Description = "Google Subscription", Amount = -15.00, Status = "Completed" },
               new TransactionModel { Id = 7, DateTime = "2020-09-06'T'07:33:23Z", Description = "Apple Store", Amount = -2000.00, Status = "Cancelled" },
               new TransactionModel { Id = 6, DateTime = "2020-08-23'T'17:39:23Z", Description = "Mini Mart", Amount = -23.76, Status = "Completed" },
               new TransactionModel { Id = 5, DateTime = "2020-08-16'T'21:06:23Z", Description = "Mini Mart", Amount = -56.43, Status = "Completed" },
               new TransactionModel { Id = 4, DateTime = "2020-06-15'T'18:17:23Z", Description = "Country Railways", Amount = -167.78, Status = "Completed" },
               new TransactionModel { Id = 3, DateTime = "2020-04-09'T'16:26:23Z", Description = "Refund", Amount = 30.00, Status = "Completed" },
               new TransactionModel { Id = 2, DateTime = "2020-04-01'T'12:47:23Z", Description = "Amazon Online", Amount = -30.00, Status = "Completed" },
               new TransactionModel { Id = 1, DateTime = "2020-03-30'T'23:53:23Z", Description = "Bank Deposit", Amount = 500.00, Status = "Completed" }
            // Add more static data as needed
            );
        }
    }
}
