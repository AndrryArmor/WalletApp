using Microsoft.AspNetCore.Mvc;
using WalletApp.Application.DTOs;
using WalletApp.Application.Services;

namespace WalletApp.WebAPI.Controllers
{
    [ApiController]
    [Route("api/user-accounts")]
    public class UserAccountController : ControllerBase
    {
        private readonly IWalletService _walletService;
        private readonly IBitmapIconService _bitmapIconService;

        public UserAccountController(IWalletService walletService, IBitmapIconService bitmapIconService)
        {
            _walletService = walletService;
            _bitmapIconService = bitmapIconService;
        }

        [HttpGet("{id}")]
        public AccountInfoDTO GetAccountInfo(int id)
        {
            var accountInfo = _walletService.GetAccountInfo(id);
            var transactions = _walletService.GetUserLastTransactions(id, 10)
                .Select(t =>
                {
                    var icon = _bitmapIconService.GetRandomBitmapIcon();
                    using var memoryStream = new MemoryStream();
                    icon.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] iconBytes = memoryStream.ToArray();

                    return new TransactionPreviewDTO(t)
                    {
                        Icon = iconBytes
                    };
                });

            return new AccountInfoDTO(accountInfo, transactions);
        }
    }
}