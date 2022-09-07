namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter 1 for Alphabet is vowe or not");
            Console.WriteLine(" Enter 2 for Find Number Positive or negative");
            Console.WriteLine(" Enter 3 for Largest Variable");
            Console.WriteLine(" Enter 4 to print Alphabet a to z");
            Console.WriteLine(" Enter 5 to find max");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    CheckAlphabets checkAlphabets = new CheckAlphabets();
                    checkAlphabets.Vowel_Consonant();
                    break;
                    case 2:
                    NumberIsPositive_Negative numberIsPositive_Negative = new NumberIsPositive_Negative();
                    numberIsPositive_Negative.NumIsPositive_Negative();
                    break;
                case 3:
                    LargestVariable largestVariable = new LargestVariable();
                    largestVariable.VariableAmongThree();
                    break;
                case 4:
                    Alphabets alphabets = new Alphabets();
                    alphabets.PrintAlphabet();
                    break;
                case 5:
                    LargestAmongThree largestAmongThree = new LargestAmongThree();
                    largestAmongThree.Max();
                    break;


            }
        }
    }
}