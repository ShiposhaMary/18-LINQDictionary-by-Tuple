using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dictionary_by_Tuple_in_LINQ
{
    class Program
    {


        public static List<string> GetSortedWords(string text)
        {
            return 
                    Regex.Split(text, @"\W+")
                    .Where(x => x != "")
                    .Select(x => x.ToLower())
                    .Distinct()
                    .OrderBy(w => Tuple.Create(w))
                    .OrderBy(z => z.Length)
                    .ToList();
        }
        public static void Main()
        {
            var vocabulary = GetSortedWords(
                "Hello, hello, hello, how low " +
                "With the lights out, it's less dangerous" +
                " Here we are now; entertain us" +
                " I feel stupid and contagious" +
                "Here we are now; entertain us" +
               " A mulatto, an albino, a mosquito, my libido..." +
               " Yeah, hey"
            );
            foreach (var word in vocabulary)
                Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
