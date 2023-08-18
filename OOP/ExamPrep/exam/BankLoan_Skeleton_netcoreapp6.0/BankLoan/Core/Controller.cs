using BankLoan.Core.Contracts;
using BankLoan.Models;
using BankLoan.Models.Contracts;
using BankLoan.Repositories;
using BankLoan.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Core
{
    public class Controller : IController
    {

        private LoanRepository loans;
        private BankRepository banks;
        public Controller()
        {
            loans = new LoanRepository();
            banks = new BankRepository();
        }
        public string AddBank(string bankTypeName, string name)
        {
            IBank bank;
            if (bankTypeName != nameof(CentralBank) && bankTypeName != nameof(BranchBank))
            {
                throw new ArgumentException("Invalid bank type.");
            }
            if (bankTypeName == nameof(CentralBank))
            {
                bank = new CentralBank(name);
            }
            else
            {
                bank = new BranchBank(name);

            }
            banks.AddModel(bank);

            return $"{bankTypeName} is successfully added.";
        }

        public string AddClient(string bankName, string clientTypeName, string clientName, string id, double income)
        {
            IClient client;
            IBank bank = banks.FirstModel(bankName);


            if (clientTypeName == nameof(Student))
            {
                client = new Student(clientName, id, income);
            }
            else if (clientTypeName == nameof(Adult))
            {
                client = new Adult(clientName, id, income);
            }
            else
            {
                throw new ArgumentException("Invalid client type.");
            }

            if (bank is CentralBank && !(client is Adult))
            {
                return "Unsuitable bank.";
            }
            else if (bank is BranchBank && !(client is Student))
            {
                return "Unsuitable bank.";

            }
            bank.AddClient(client);
            return $"{clientTypeName} successfully added to {bankName}.";
        }

        public string AddLoan(string loanTypeName)
        {
            ILoan loan;
            if (loanTypeName == nameof(StudentLoan))
            {
                loan = new StudentLoan();
            }
            else if (loanTypeName == nameof(MortgageLoan))
            {
                loan = new MortgageLoan();
            }
            else
            {
                throw new ArgumentException("Invalid loan type.");
            }
            loans.AddModel(loan);
            return $"{loanTypeName} is successfully added.";
        }

        public string FinalCalculation(string bankName)
        {
            IBank bank = banks.FirstModel(bankName);

            var totalFunds = bank.Clients.Sum(client => client.Income) + bank.SumRates();

            return $"The funds of the bank {bankName} are {totalFunds:f2}.";

        }

        public string ReturnLoan(string bankName, string loanTypeName)
        {
            IBank bank = banks.FirstModel(bankName);
            ILoan loan = loans.FirstModel(loanTypeName);

            if (loan == null)
            {
                throw new ArgumentException($"Loan of type {loanTypeName} is missing.");
            }
            bank.AddLoan(loan);
            loans.RemoveModel(loan);
            return $"{loanTypeName} successfully added to {bankName}.";
        }

        public string Statistics()
        {
            StringBuilder sb = new StringBuilder();

            foreach (IBank bank in banks.Models)
            {
                sb.AppendLine(bank.GetStatistics());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
