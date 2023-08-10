using Microsoft.AspNetCore.Mvc;
using WalletApp.Application.Services;
using WalletApp.Domain.Entities;

namespace WalletApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionController : ControllerBase
    {
        private readonly IWalletService _walletService;

        public TransactionController(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpGet("{id}")]
        public Transaction GetTransactionInfo(int id)
        {
            return _walletService.GetTransaction(id);
        }
    }
}
