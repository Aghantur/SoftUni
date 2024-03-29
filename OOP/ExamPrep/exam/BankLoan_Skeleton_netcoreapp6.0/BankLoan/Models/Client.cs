﻿using BankLoan.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLoan.Models
{
    public abstract class Client : IClient
    {
        private string name;
        private string id;
        private double income;


        public Client(string name, string id, int interest, double income)
        {
            this.Name = name;
            this.Id = id;
            this.Interest = interest;
            this.Income = income;
        }
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Client name cannot be null or empty.");
                }

                name = value;
            }
        }

        public string Id
        {
            get => id;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Client’s ID cannot be null or empty.");
                }
                id = value;
            }
        }

        public int Interest { get; set; }

        public double Income
        {
            get => income;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Income cannot be below or equal to 0.");
                }

                income = value;
            }
        }

        public abstract void IncreaseInterest();
        
    }
}
