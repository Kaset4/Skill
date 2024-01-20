using System.Collections;
using System.ComponentModel;
using System.Diagnostics;

namespace HelloWOrld;

class Program
{
    public class Contact // модель класса
   {
       public Contact(string name, string lastName, long phoneNumber, String email) // метод-конструктор
       {
           Name = name;
           LastName = lastName;
           PhoneNumber = phoneNumber;
           Email = email;
       }
  
       public String Name {get;}
       public String LastName {get;}
       public long PhoneNumber {get;}
       public String Email {get;}
   }
    static  void Main(string[] args)
    {
        //  создаём пустой список с типом данных Contact
           var phoneBook = new List<Contact>();
     
           // добавляем контакты
           phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
           phoneBook.Add(new Contact("Сергей", "Довлатов",79990000010, "serge@example.com"));
           phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
           phoneBook.Add(new Contact("Валерий", "Леонтьев",79990000012, "valera@example.com"));
           phoneBook.Add(new Contact("Сергей", "Брин",  799900000013, "serg@example.com"));
           phoneBook.Add(new Contact("Иннокентий", "Смоктуновский",799900000013, "innokentii@example.com"));

           var result = from item in phoneBook orderby item.Name, item.LastName select item;

           foreach (var item in result)
           {
            System.Console.WriteLine($"{item.Name} {item.LastName}, {item.PhoneNumber}, {item.Email}");
           }
    }
}
