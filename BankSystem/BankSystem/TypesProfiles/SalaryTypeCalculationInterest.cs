using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.TypesProfiles
{
    public class SalaryTypeCalculationInterest : ITypeCalculateInterest
    {
        public void Execute(Account account)
        {
            if (account.Type == "Зарплатный")
            {
                account.Interest = account.Balance * 0.5;
            }
        }
    }
}
