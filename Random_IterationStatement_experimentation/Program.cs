using System;
using System.ComponentModel;

namespace Random_IterationStatement_experimentation
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while (number <= 20)
            {
                Console.WriteLine(number++);

            }

            int numberofhis = 0;

            do
            {
                numberofhis++;
                Console.WriteLine("HI!");

            }
            while (numberofhis <= 5);

            Console.WriteLine("For loop: \n 0-100 iteration loop experiment:\n---------------------------------------------");

            for (int fornumber = 0; fornumber <= 100; ++fornumber)
            {
                Console.WriteLine("Iterations:" + fornumber);


                if (fornumber == 100)
                {
                    Console.WriteLine("There we have it, a grand total of: " + fornumber + " total iteraions.\n\n");

                }

            }



            int[] numberlist = new int[5];

            numberlist[0] = 2;
            numberlist[1] = 2;
            numberlist[2] = 4;
            numberlist[3] = 6;
            numberlist[4] = 8;


            Console.WriteLine("Let's try a little arithmatic starting with addition.. ah, such beautiful even numbers..\n------------------------------------------------:");
            foreach (int addend in numberlist)
            {

                
                Console.WriteLine(addend + addend);
             
           
            }

            Console.WriteLine("And now, subtraction: \n");

            foreach( int Subtrahend in numberlist)
            {
                Console.WriteLine(Subtrahend - Subtrahend);
            }

            Console.WriteLine("Everything evaluates to zero since we are subtratcing these values only by themelves. \n \n On to Multiplication!: \n ");
            foreach(int multiplier in numberlist)
            {
                Console.WriteLine(multiplier * multiplier);
            }
            Console.WriteLine("Now there's a huge number.. Let's finish off with some division, this should only produce zeros : \n \n And now We conclude with division of all elements in the array!");

            foreach(int divisor in numberlist)
            {
                Console.WriteLine(divisor / divisor);

            }
            Console.WriteLine("\n And there we have it, I WOULD include modulus but, it would literally just return the result of multiplication and subtraction, 5 zeros.");

        }
    }
}
