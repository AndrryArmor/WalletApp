using Microsoft.AspNetCore.Mvc;
using WalletApp.Application.DTOs;
using WalletApp.Application.Services;
using WalletApp.Application.Tools;

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
        public AccountInfoDTO GetAccountInfo(int id)
        {
            var accountInfo = _walletService.GetAccountInfo(id);
            var transactions = _walletService.GetUserLastTransactions(id, 10)
                .Select(t =>
                {
                    var icon = BitmapIconUtils.GetRandomBitmapIcon();
                    var iconBytes = BitmapIconUtils.ConvertIconToBytes(icon);
                    return new TransactionPreviewDTO(t)
                    {
                        IconBytes = iconBytes
                    };
                });

            return new AccountInfoDTO(accountInfo, transactions);
        }
    }
}