using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WalletApp.Application.ResponseModels;
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
        private readonly IBitmapIconService _bitmapIconService;
        private readonly Random _random;

        public UserAccountController(IWalletService walletService, IDailyPointsService dailyPointsService, IBitmapIconService bitmapIconService)
        {
            _walletService = walletService;
            _dailyPointsService = dailyPointsService;
            _bitmapIconService = bitmapIconService;
            _random = new Random();
        }

        [HttpGet("{id}")]
        public GetAccountInfoResponse GetAccountInfo(int id)
        {
            var currentDateTime = DateTime.Now;
            var monthName = currentDateTime.ToString("MMMM", CultureInfo.InvariantCulture);
            var dailyPoints = _dailyPointsService.CalculateDailyPoints(currentDateTime);
            var dailyPointsString = _dailyPointsService.GetStringRepresentation(dailyPoints);
            var transactions = _walletService.GetUserLastTransactions(id, 10)
                .Select(t =>
                {
                    var icon = _bitmapIconService.GetRandomBitmapIcon();
                    using var memoryStream = new MemoryStream();
                    icon.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] iconBytes = memoryStream.ToArray();

                    return new TransactionPreview(t)
                    {
                        Icon = iconBytes
                    };
                });

            return new GetAccountInfoResponse()
            {
                CardBalance = _random.Next(GetAccountInfoResponse.MaxLimit),
                NoPaymentDueMessage = $"You've paid your {monthName} balance.",
                DailyPoints = dailyPointsString,
                Transactions = transactions
            };
        }
    }
}