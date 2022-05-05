using System;

namespace OOPs_JSON
{
    public class max
    {
        
        int a = Convert.ToInt16(Console.ReadLine());
        int b = Convert.ToInt16(Console.ReadLine());
        int c = Convert.ToInt16(Console.ReadLine());
        public int MaxOfThree(int a, int b, int c)
        {
            int result;

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("{0} is the largest value ", a);
                    result = a;
                }
                else
                {
                    Console.WriteLine("{0} is the largest value ", c);
                    result = b;
                }
            }
            else if (b > c)
            {
                Console.WriteLine("{0} is the largest value ", b);
                result = b;
            }
            else
            {
                Console.WriteLine("{0} is the largest value ", c);
                result = c;
            }
            return result;
        }

    }


}