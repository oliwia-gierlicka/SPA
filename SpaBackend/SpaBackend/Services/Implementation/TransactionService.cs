using SpaBackend.Db;
using SpaBackend.Db.Entity;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Services.Implementation;

public class TransactionService : ITransactionService
{
    private readonly SpaDbContext _db;

    public TransactionService(SpaDbContext db)
    {
        _db = db;
    }

    public IDictionary<Guid, IEnumerable<Transaction>> GetTransactions(int userid)
    {
        return _db.Transactions.Where(x => x.UserId == userid).GroupBy(x => x.TransactionId)
            .ToDictionary(x => x.Key, x => x.AsEnumerable());
    }
}