using SpaBackend.Db.Entity;

namespace SpaBackend.Services.Abstract;

public interface ITransactionService
{
    IEnumerable<Transaction> GetTransactions(int userid);
}