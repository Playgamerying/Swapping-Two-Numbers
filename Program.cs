using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 20;
            int temp;

            Console.WriteLine("Before swapping num1={0} and num2={1}",num1,num2);

            temp = num1; //temp=10
            num1 = num2; //num1=20
            num2 = temp; //num2=10

            Console.WriteLine("After swapping num1={0} and num2={1}", num1, num2);
            Console.ReadLine();


            int a = 75;
            int b = 34;

            Console.WriteLine("Before swapping a={0} and b={1}", a, b);

            a = a + b; //a = 109 (75 + 34 = 109)
            b = a - b; //b = 75 (109 - 34 = 75)
            a = a - b; //a = 34 (109 - 75 = 34)

            Console.WriteLine("After swapping a={0} and b={1}", a, b);
            Console.ReadLine();

        }
    }
}
