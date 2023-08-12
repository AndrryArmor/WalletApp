using Microsoft.AspNetCore.Mvc;
using WalletApp.Application.DTOs;
using WalletApp.Application.Services;

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
        public TransactionDTO GetTransactionInfo(int id)
        {
            var transaction = _walletService.GetTransaction(id);
            return new TransactionDTO(transaction);
        }
    }
}
