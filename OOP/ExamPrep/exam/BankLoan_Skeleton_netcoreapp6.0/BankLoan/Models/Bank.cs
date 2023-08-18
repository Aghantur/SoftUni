using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public abstract class Bank : IBank
    {
       private readonly IRepository<ILoan> loansRepo;

        private List<ILoan> loans = new List<ILoan>();
        private List<IClient> clients = new List<IClient>();
        public Bank(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.loansRepo = new LoanRepository();
        }
        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<ILoan> Loans => this.loans;

        public IReadOnlyCollection<IClient> Clients => this.clients;

        public void AddClient(IClient Client)
        {
            if (Clients.Count >= Capacity)
            {
                throw new ArgumentException("Not enough capacity for this client.");
            }
            clients.Add(Client);

        }

        public void AddLoan(ILoan loan)
        {
            loans.Add(loan);
        }

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}, Type: {this.GetType().Name}");

            if (!Clients.Any())
            {
                sb.AppendLine("Clients: none");
            }
            foreach (var item in Clients)
            {
                sb.AppendLine($"{item}");
                
            }
            sb.AppendLine($"Loans: {Loans.Count}, Sum of Rates: {SumRates()}");

            return sb.ToString().TrimEnd();
        }

        public void RemoveClient(IClient Client)
        {

          clients.Remove(Client);

        }

        public double SumRates()
        {
            return loans.Sum(loan => loan.InterestRate);

        }
    }
}
