using System;

namespace BasicCoreProgram
{
    class OddEven
    {
        public static void OddEven2()
        {
            int number;
            Console.WriteLine("Enter Number");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Entered number is Even " + number);
            }
            else
            {
                Console.WriteLine("Entered number is Odd " + number);
            }
        }
}
}
