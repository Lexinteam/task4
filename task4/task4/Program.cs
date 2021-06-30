using System;

namespace task4
{

    class Program
    {
        static void Main(string[] args)
        {
            // Palindrome
            Calc calc1 = new Calc();

            //calc1.ShowResult();

            Console.Read();
        }



        class Calc
        {

            private int number1;
            private int number2;
            private bool valid1 = false;
            private bool valid2 = false;
            private int[] array1;
            private int[] arrayForSum;
            private int finalSum;

            public Calc()
            {
                Console.WriteLine("Please enter a word to find out if it is a palindrome");

                string string1, rev;
                string1 = Console.ReadLine();
                char[] ch = string1.ToCharArray();
                Array.Reverse(ch);
                rev = new string(ch);
                bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
                if (b == true)
                {
                    Console.WriteLine("" + string1 + " is a Palindrome!");
                }
                else
                {
                    Console.WriteLine(" " + string1 + " is not a Palindrome!");
                }


            }
        }
    }
}
