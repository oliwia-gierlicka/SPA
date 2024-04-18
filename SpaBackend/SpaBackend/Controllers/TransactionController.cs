using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpaBackend.Services.Abstract;

namespace SpaBackend.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class TransactionController:ControllerBase
{
    private readonly ITransactionService _transactionService;
    private readonly IUserProvider _userProvider;

    public TransactionController(ITransactionService transactionService, IUserProvider userProvider)
    {
        _transactionService = transactionService;
        _userProvider = userProvider;
    }

    [HttpGet]
    public ActionResult Get()
    {
        var userId = _userProvider.GetUserId();
        return Ok(_transactionService.GetTransactions(userId));
    }
}