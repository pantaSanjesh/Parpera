using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TransactionUpdate.DalLayer.Data;
using TransactionUpdate.DalLayer.Model;

namespace TransactionUpdate.DalLayer.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private List<TransactionModel> _transactions = new List<TransactionModel>
    {
        new TransactionModel { Id = 11,DateTime ="2020-09-08'T'16:34:23Z",Description =" Bank Deposit" ,Amount= 500.00, Status = "Completed" },
        new TransactionModel { Id = 10, DateTime = "2021-09-08'T'09:02:23Z",Description= "Transfer to James", Amount =-20.00,Status = "Pending" },
        
    };
        private readonly TransactionDbContext _transactionDbContext;
        public TransactionRepository(TransactionDbContext transactionDbContext)
        {
            _transactionDbContext = transactionDbContext;
        }
        public List<TransactionModel> GetAllTransactions()
        {
          

            var orderedTransactionList = _transactionDbContext.Transactions.OrderByDescending(x =>x.DateTime.Replace("'","")).ToList();
            return orderedTransactionList;
        }

        public TransactionModel GetById(int id)
        {
            return _transactionDbContext.Transactions.FirstOrDefault(t => t.Id == id);
        }

        public void UpdateStatus(int id, string newStatus)
        {
            try
            {
                var transaction = GetById(id);

                if (transaction == null)
                {
                    throw new Exception("Transaction not found");
                }

                transaction.Status = newStatus;

                _transactionDbContext.Transactions.Update(transaction);
                _transactionDbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
