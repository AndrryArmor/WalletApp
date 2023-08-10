using Microsoft.AspNetCore.Mvc;

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
        public IEnumerable<WeatherForecast> GetTransactionInfo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
