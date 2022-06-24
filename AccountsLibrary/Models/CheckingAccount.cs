using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using AccountsLibrary.Classes.Events;
using AccountsLibrary.Interfaces;

using AO = AccountsLibrary.Classes.AccountOperations;

namespace AccountsLibrary.Models
{
    public class CheckingAccount : IBaseAccount, 
        IComparable<CheckingAccount>, 
        INotifyPropertyChanged
    {
        #region fields

        private decimal _warningLevel;
        private bool _insufficientFunds;
        private decimal _balance;
        private string _pin;
        private string _firstName;
        private string _lastName;

        #endregion

        #region events
        public event BalanceWarningDelegate BalanceWarning;
        public event DenyDelegate AccountDenial;
        #endregion

        /// <summary>
        /// Primary key
        /// </summary>
        public int AccountId { get; set; }
        /// <summary>
        /// Account number alpha numeric
        /// </summary>
        public string Number { get; set; }
        /// <summary>
        /// For login
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// For login
        /// </summary>
        public string PIN
        {
            get => _pin;
            set
            {
                _pin = value;
                OnPropertyChanged();
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged();
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged();
            }
        }

        public List<Transaction> Transactions { get; set; } 

        public CheckingAccount()
        {
            Transactions = new List<Transaction>();
            _warningLevel = 10M;
        }

        /// <summary>
        /// Warning level is when to send an alert via our delegate
        /// </summary>
        public CheckingAccount(decimal warningLevel)
        {
            Transactions = new List<Transaction>();
            _warningLevel = warningLevel;
            _insufficientFunds = Balance <= 0M;
        }

        /// <summary>
        /// Current balance of account
        /// </summary>
        /// <remarks>Read-only</remarks>
        public virtual decimal Balance
        {
            get
            {
                _balance = AO.CalculateBalance(this);
                return _balance;

            }

            private set => _balance = value;

        }

        /// <summary>
        /// Deposit money into account
        /// </summary>
        public decimal Deposit(Transaction transaction)
        {
            /*
             * Initial transaction - when using a database, the database handles keys
             */
            if (Transactions.Count == 0)
            {
                transaction.TransactionId = 1;
            }
            else
            {
                transaction.TransactionId = Transactions.LastOrDefault().TransactionId + 1;
            }
            
            Transactions.Add(transaction);
            
            Balance += transaction.Amount;

            if (Balance < _warningLevel && BalanceWarning is not null)
            {

                BalanceWarning?.Invoke(this, 
                    new(Number, _warningLevel, Balance));

            }

            if (Balance - transaction.Amount < 0M)
            {
                
                _insufficientFunds = true;

                AccountDenial?.Invoke(this, 
                    new(
                        DenialReasons.InsufficientFunds, Balance));
            }
            else
            {
                _insufficientFunds = false;
            }

            IList<CheckingAccount> list = new List<CheckingAccount>(AO.ReadAccountsFromFile());

            var current = list.FirstOrDefault(checkingAccount => 
                checkingAccount.AccountId == transaction.AccountId);

            current.Transactions.Add(transaction);
            AO.Update(current);

            return Balance;

        }
        /// <summary>
        /// Withdraw from account
        /// </summary>
        public decimal Withdraw(Transaction transaction)
        {
            if (Transactions.Count == 0)
            {
                throw new Exception("There is no account for this transaction");
            }

            transaction.TransactionId = Transactions.LastOrDefault().TransactionId + 1;
            Transactions.Add(transaction);

            if (Balance - transaction.Amount < 0M)
            {
                _insufficientFunds = true;
                AccountDenial?.Invoke(this, new(DenialReasons.InsufficientFunds, Balance));

                return Balance;
            }

            Balance -= transaction.Amount;

            BalanceWarning?.Invoke(this, new(Number, _warningLevel, Balance));

            return Balance;

        }
        
        public bool InsufficientFunds => _insufficientFunds;

        public override string ToString() => $"{AccountId,-4}{Balance:C}";

        /// <summary>
        /// For IComparable&lt;CheckingAccount&gt;
        /// </summary>
        public int CompareTo(CheckingAccount account) => Balance.CompareTo(account.Balance);

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

    }
}