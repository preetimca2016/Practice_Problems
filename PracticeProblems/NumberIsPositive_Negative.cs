using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class NumberIsPositive_Negative
    {
        public void NumIsPositive_Negative()
        {
            int Num;
            Console.WriteLine("Enter any integer value");
            Num = Convert.ToInt32(Console.ReadLine());
            if (Num > 0)
            {
                Console.WriteLine("{0} is Positive Number.\n", Num);
            }
            else if (Num < 0)
            {
                Console.WriteLine("{0} is a Negative Number \n", Num);
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}
