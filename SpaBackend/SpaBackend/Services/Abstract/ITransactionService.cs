using SpaBackend.Db.Entity;

namespace SpaBackend.Services.Abstract;

public interface ITransactionService
{
    IDictionary<Guid, IEnumerable<Transaction>> GetTransactions(int userid);
}