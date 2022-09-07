using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public class Alphabets
    {
        public void PrintAlphabet()
        {
            char ch;
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                Console.Write(ch + " ");
            }
            Console.ReadKey();
        }
    }
}
