using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WalletApp.Application.Services;
using WalletApp.Domain.Entities;

namespace WalletApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/user-accounts")]
    public class UserAccountController : ControllerBase
    {
        private readonly IWalletService _walletService;
        private readonly IDailyPointsService _dailyPointsService;
        private readonly Random _random;

        public UserAccountController(IWalletService walletService, IDailyPointsService dailyPointsService)
        {
            _walletService = walletService;
            _dailyPointsService = dailyPointsService;
            _random = new Random();
        }

        [HttpGet("{id}")]
        public AccountInfoResponse GetAccountInfo(int id)
        {
            var currentDateTime = DateTime.Now;
            var monthName = currentDateTime.ToString("MMMM", CultureInfo.InvariantCulture);
            var dailyPoints = _dailyPointsService.CalculateDailyPoints(currentDateTime);
            return new AccountInfoResponse()
            {
                CardBalance = _random.Next(AccountInfoResponse.MaxLimit),
                NoPaymentDueMessage = $"You've paid your {monthName} balance.",
                DailyPoints = _dailyPointsService.GetStringRepresentation(dailyPoints),
                Transactions = _walletService.GetUserLastTransactions(id, 10)
            };
        }
    }
}