using System;
using System.Linq;

namespace LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int LengthOfLastWordMethod(string s)
        {
            if (s.Length == 0 || s == string.Empty || s == " ")
                return 0;

            int startIndex = 0;
            int endIndex = s.Length -1;
            int currentIndex = s.Length - 1;

            bool foundEndIndex = false;

            if(s[s.Length - 1] != ' ')
                foundEndIndex = true;

            while(currentIndex >= 0)
            {
                if(!foundEndIndex)
                {
                    if(s[currentIndex] != ' ')
                        foundEndIndex = true;

                    endIndex = currentIndex;                    
                }

                if(foundEndIndex && s[currentIndex] == ' ')
                {
                    startIndex = currentIndex + 1;
                    break;
                }

                currentIndex--;
            }

            return s[endIndex] == ' ' ? 0 : endIndex -startIndex + 1;
        }

        public int LengthOfLastWordLinq(string s)
        {
            var t = s.Split(" ").Select(x => x).Where(x => x!= "");
            return t.Count() == 0 ? 0 : t.Last().Length;
        }
    }
}
