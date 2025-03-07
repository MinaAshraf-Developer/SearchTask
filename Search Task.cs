using System;

namespace Specifier_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int x = 10;
            int y = 20;

            Console.WriteLine($"Equation : {x} + {y} = {(x + y):C0}");
            Console.WriteLine($"Equation : {x} + {y} = {(x + y):C0}");
            Console.WriteLine($"Equation : {x} + {y} = {(x + y):D2}");

            // 1- Why the out put of this equation is $30.00?
            // Because the C is a Currency Simplifier so,
            // it makes the output result a $ sign with the number result

            // 2- what is its benefit?
            // It makes it easy to to swith between Currencies
            // Its up to date calculated exchange rate
            // It saves time because it gives fast conversion results

            //3- Try another example with differnt simplifier example 

            Console.WriteLine($"The result in C# test is {1:P0}");
            // output : The result in C# test is 100%
            // I added the P0 to make it percentage with no decimals

        }
    }
}
