using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace HelloWOrld;

class Program
{
   static string [] GetAllStudents( Classroom [] classes )
       {
           return  (from classroom in classes from student in classroom.Students select student).ToArray();
       }
      
       public class Classroom
       {
           public List<string> Students = new List<string>();
       }
    static  void Main(string[] args)
    {
        var classes = new []
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
           var allStudents = GetAllStudents(classes);
         
           Console.WriteLine(string.Join(" ", allStudents));
    }
}
