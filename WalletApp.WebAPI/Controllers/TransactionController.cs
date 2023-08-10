using Microsoft.AspNetCore.Mvc;
using WalletApp.Domain.Entities;

namespace WalletApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/transactions")]
    public class TransactionController : ControllerBase
    {
        public TransactionController()
        {
        }

        [HttpGet("{id}")]
        public IEnumerable<Transaction> GetTransactionInfo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
