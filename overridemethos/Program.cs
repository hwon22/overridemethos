using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        static int Power(int input)
        {
            return input*input;
           
        }
        static int Power(int input, int count)
        {
            int num = 1;
            for(int i=0; i<count; i++)
            {
                num = num * input;
            }
            return num;
        }
        static int SumAll(int end)
        {
            int sum = 0;
            for(int i=0; i<=end; i++)
            {
                sum += i;
            }
            return sum;
        }
        static int SumAll(int start,int end)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Power(9));
            Console.WriteLine(Power(3, 4));
            Console.WriteLine(SumAll(5));
            Console.WriteLine(SumAll(5,10));
        }
    }
}
