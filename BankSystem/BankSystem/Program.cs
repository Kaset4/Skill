using BankSystem;
using BankSystem.TypesProfiles;
using System.Security.Principal;

public class Program
{
    static void Main(string[] args)
    {
        Account account1 = new Account("Зарплатный", 500);

        account1.CalculateInterest(new SalaryTypeCalculationInterest());

        Console.WriteLine("Процентная ставка: " + account1.Interest);

        Account account2 = new Account("Обычный", 500);

        account2.CalculateInterest(new UsualTypeCalculationInterest());

        Console.WriteLine("Процентная ставка: " + account2.Interest);
    }
}