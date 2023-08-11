using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletApp.Domain.Entities;

namespace WalletApp.Application.ResponseModels
{
    public class TransactionDTO
    {
        public TransactionDTO(Transaction transaction)
        {
            TransactionType = transaction.TransactionType;
            Sum = transaction.Sum;
            Title = transaction.Title;
            Description = transaction.Description;
            Date = transaction.Date;
            IsPending = transaction.IsPending;
            AuthorizedUser = transaction.AuthorizedUser;
        }

        public TransactionType TransactionType { get; }
        public decimal Sum { get; }
        public string Title { get; } = string.Empty;
        public string? Description { get; } 
        public DateTime Date { get; }
        public bool IsPending { get; }
        public string? AuthorizedUser { get; }
    }
}
