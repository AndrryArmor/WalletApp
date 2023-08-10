using Microsoft.AspNetCore.Mvc;

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
        public WeatherForecast GetAccountInfo(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("{id}/transactions")]
        public IEnumerable<WeatherForecast> GetLastTransactionsPreview(int id)
        {
            throw new NotImplementedException();
        }
    }
}