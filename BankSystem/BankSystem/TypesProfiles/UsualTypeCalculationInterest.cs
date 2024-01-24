using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.TypesProfiles
{
    public class UsualTypeCalculationInterest : ITypeCalculateInterest
    {
        public void Execute(Account account)
        {
            if(account.Type == "Обычный")
            {
                if (account.Balance < 1000)
                    account.Interest = account.Balance * 0.2;

                if (account.Balance >= 1000)
                    account.Interest = account.Balance * 0.4;
            }
        }
    }
}
