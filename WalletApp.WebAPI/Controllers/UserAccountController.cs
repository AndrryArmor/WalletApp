using Microsoft.AspNetCore.Mvc;
using WalletApp.Domain.Entities;

namespace WalletApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/user-accounts")]
    public class UserAccountController : ControllerBase
    {
        public UserAccountController()
        {
        }

        [HttpGet("{id}")]
        public Account GetAccountInfo(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}/transactions")]
        public IEnumerable<Transaction> GetLastTransactionsPreview(int id)
        {
            throw new NotImplementedException();
        }
    }
}