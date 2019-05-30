using System;

namespace Fibonacci
{
    using System;

    class FibSum
    {
        static int evenSum(int limit)
        {
            if (limit < 2)
                return 0;
            
            long num1 = 0, num2 = 2;
            long sum = num1 + num2;
             
            while (num2 <= limit)
            {              
                long num3 = 4 * num2 + num1;
 
                if (num3 > limit)
                    break;
 
                num1 = num2;
                num2 = num3;
                sum += num2;
            }

            return (int)sum;
        }        
        public static void Main()
        {
            int limit = 4000000;
            Console.Write(evenSum(limit));

        }
    }
}
