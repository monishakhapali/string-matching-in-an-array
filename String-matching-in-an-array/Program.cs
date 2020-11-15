using System;
using System.Collections.Generic;

namespace String_matching_in_an_array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string[] words = { "mass", "as", "hero", "superhero" };
            IList<string> s =StringMatching(words);
            Console.WriteLine(string.Join(" ", s));
            Console.ReadLine();
    }
        public static IList<string> StringMatching(string[] words)
        {

            List<string> substring = new List<string>();
            for(int i=0;i< words.Length;i++)
            {
                for(int j=0;j< words.Length;j++)
                {
                    if(words[i]!= words[j] && words[j].Contains(words[i]))
                    {
                        if(!substring.Contains(words[i]))
                        {
                            substring.Add(words[i]);
                        }
                    }
                }
            }
            return substring;
        }
    }
}
