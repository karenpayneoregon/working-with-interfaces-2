using System.Collections.Generic;
using AccountsLibrary.Models;

namespace AccountsLibrary.Interfaces
{
    /// <summary>
    /// Defines common methods and properties for banking
    /// </summary>
    public interface IBaseAccount
    {
        public int AccountId { get; set; }
        decimal Balance { get; }
        public decimal Deposit(Transaction transaction);
        public decimal Withdraw(Transaction transaction);
        string FirstName { get; set; }
        string LastName { get; set; }
        public string PIN { get; set; }
        public string UserName { get; set; }
        public List<Transaction> Transactions { get; set; }
    }

}
