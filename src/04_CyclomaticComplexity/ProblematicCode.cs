namespace _04_CyclomaticComplexity
{
    using System.Collections.Generic;
    using System.Linq;

    public class ProblematicCode
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
                if (string.IsNullOrEmpty(clientName) || string.IsNullOrWhiteSpace(clientName))
                {
                    // Throw exception
                }

                if (this.clients.Any(c => c == clientName))
                {
                    // Throw exception
                }

                if (amount <= 0)
                {
                    // Throw exception
                }

                if (this.Amount <= amount)
                {
                    // Throw exception
                }
                // Todo: Logic
            }
        }
    }
}
