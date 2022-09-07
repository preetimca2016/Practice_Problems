using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class CheckAlphabets
    {
        public  void Vowel_Consonant()
        {
            Console.WriteLine("Enter Any Character");
            var ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine(ch+ " is Vowel");
            }
            else 
            {
                Console.WriteLine(ch+ " Consonant");
            }
            Console.ReadLine();
        }
    }
}
