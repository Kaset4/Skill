using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.TypesProfiles
{
    public interface ITypeCalculateInterest
    {
        void Execute(Account account);
    }
}
