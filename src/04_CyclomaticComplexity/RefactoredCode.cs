namespace _04_CyclomaticComplexity
{
    using System.Collections.Generic;
    using System;
    using System.Linq;

    public class RefactoredCode
    {
        public class Bank
        {
            private readonly ICollection<string> clients;

            private Bank() => this.clients = new HashSet<string>();

            public Bank(decimal amount)
                : this() => this.Amount = amount;

            public decimal Amount { get; init; }

            public void Transfer(string clientName, decimal amount)
            {
                this.ValidateClientName(clientName);

                this.CheckIsUserExistByName(clientName);

                this.CheckIsAmountPositive(amount);

                this.CheckIsUserHasEnoughMoney(amount);

                // Todo: Logic
            }

            private void ValidateClientName(string name)
            {
                if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentNullException();
                }
            }

            private void CheckIsUserExistByName(string name)
            {
                if (!this.clients.Any(c => c == name))
                {
                    throw new ArgumentException();
                }
            }

            private void CheckIsAmountPositive(decimal amount)
            {
                if (amount <= 0)
                {
                    throw new ArgumentException();
                }
            }

            private void CheckIsUserHasEnoughMoney(decimal money)
            {
                if (this.Amount < money)
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
