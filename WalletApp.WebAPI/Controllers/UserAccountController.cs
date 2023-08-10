using Microsoft.AspNetCore.Mvc;
using WalletApp.Application.Services;
using WalletApp.Domain.Entities;

namespace WalletApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/user-accounts")]
    public class UserAccountController : ControllerBase
    {
        private readonly IWalletService _walletService;

        public UserAccountController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpGet("{id}")]
        public Account GetAccountInfo(int id)
        {
            return _walletService.GetUserAccountInfo(id);
        }

        [HttpGet("{id}/transactions")]
        public IEnumerable<Transaction> GetLastTransactionsPreview(int id)
        {
            return _walletService.GetUserLastTransactions(id, 10);
        }
    }
}