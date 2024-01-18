using System.Collections;
using System.Diagnostics;

namespace HelloWOrld;

class Program
{
    static  void Main(string[] args)
    {
        string text = File.ReadAllText("C:\\Users\\Егор\\Desktop\\1.txt");

        char[] sym = new char[] {' ', '\r', '\n' };
          
        string[] words = text.Split(sym, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordsDict = new Dictionary<string, int>();

        foreach (var item in words)
        {
            if(wordsDict.ContainsKey(item)) 
            {
                wordsDict[item]++;
            } else
            {
                wordsDict[item] = 1;
            }
        }
        
        var topWords = wordsDict.OrderByDescending(c => c.Value).Take(10);

        foreach (var item in topWords)
        {
            System.Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
