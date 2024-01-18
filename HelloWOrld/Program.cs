using System.Collections;
using System.Diagnostics;

namespace HelloWOrld;

class Program
{
    static  void Main(string[] args)
    {
        Stopwatch stopwatch = new Stopwatch();

        string text = File.ReadAllText("C:\\Users\\Егор\\Desktop\\1.txt");

        char[] sym = new char[] {' ', '\r', '\n' };
          
        string[] words = text.Split(sym, StringSplitOptions.RemoveEmptyEntries);

        List<string> ListTest = new List<string>();
        LinkedList<string> LinkedListTest = new LinkedList<string>();

        stopwatch.Start();
        for (int i = 0; i < words.Length; i++)
        {
            ListTest.Add(words[i]);
        }
        stopwatch.Stop();

        System.Console.WriteLine($"ListTest:  {stopwatch.ElapsedTicks}");

        stopwatch.Reset();

        stopwatch.Start();
        for (int i = 0; i < words.Length; i++)
        {
            LinkedListTest.AddLast(words[i]);
        }
        stopwatch.Stop();

        System.Console.WriteLine($"LinkedListTest:  {stopwatch.ElapsedTicks}");
    }
}
