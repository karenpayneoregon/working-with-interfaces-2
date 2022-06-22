using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AccountsLibrary.Interfaces;

namespace AccountsLibrary.Models
{
    public class IndividualRetirementAccount : IBaseAccount, INotifyPropertyChanged
    {
        public int AccountId { get; set; }
        public decimal Balance { get; }
        public decimal Deposit(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public decimal Withdraw(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> Transactions { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
