using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.ResponseModels
{
    public class TransactionPreview
    {
        public TransactionPreview(Transaction transaction)
        {
            Title = transaction.Title;
            Sum = transaction.TransactionType switch
            {
                TransactionType.Payment => $"+${transaction.Sum:F}",
                _ => $"${transaction.Sum:F}"
            };
            FirstLineDescription = transaction.IsPending switch
            {
                true => $"Pending - {transaction.Description ?? ""}",
                _ => transaction.Description ?? ""
            };
            SecondLineDescription = transaction.AuthorizedUser switch
            {
                not null => $"{transaction.AuthorizedUser} - {transaction.Date.ToShortDateString()}",
                _ => transaction.Date.ToShortDateString()
            };
        }

        public string Title { get; }
        public string Sum { get; }
        public string FirstLineDescription { get; }
        public string SecondLineDescription { get; }
        public byte[]? Icon { get; set; }
    }
}
