using BankSystem.TypesProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {
        // тип учетной записи
        public string Type { get; set; }

        // баланс учетной записи
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }

        public Account(string type, double balance)
        {
            Type = type;
            Balance = balance;
        }

        public void CalculateInterest(ITypeCalculateInterest typeCalculateInterest)
        {
            typeCalculateInterest.Execute(this);
        }
    }
}
