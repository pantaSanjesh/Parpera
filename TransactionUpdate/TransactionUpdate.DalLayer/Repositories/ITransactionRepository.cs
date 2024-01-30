
using TransactionUpdate.DalLayer.Model;

namespace TransactionUpdate.DalLayer.Repositories
{
    public interface ITransactionRepository
    {
        TransactionModel GetById(int id);

        List<TransactionModel> GetAllTransactions();
        void UpdateStatus(int id, string newStatus);
    }
}
