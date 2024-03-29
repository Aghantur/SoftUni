﻿using BankLoan.Models.Contracts;
using BankLoan.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Repositories
{
    public class LoanRepository : IRepository<ILoan>
    {
        private List<ILoan> loans;

        public IReadOnlyCollection<ILoan> Models => this.loans;
        public LoanRepository()
        {
                loans = new List<ILoan>();
        }

        public void AddModel(ILoan model)
        {
            loans.Add(model);
        }

        public ILoan FirstModel(string name)
        {
            return this.loans.FirstOrDefault(x => x.GetType().Name == name);
            
        }

        public bool RemoveModel(ILoan model)
        {
            return loans.Remove(model);
        }
    }
}
