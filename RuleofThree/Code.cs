using System;

namespace RuleOfThree
{

    class Code
    {
        static void Main()
        {
            //Variables
            float n1, n2, n3, result;

            //Print Console and Questions

            Console.Clear();

            Console.WriteLine("--------------------");
            Console.WriteLine("-   Rule of Three  -");
            Console.WriteLine("-     Calculator   -");
            Console.WriteLine("--------------------");
            Console.WriteLine("-   1     |    2   -");
            Console.WriteLine("-   3     |    X   -");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.Write("Enter first numer to replace number 1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("--------------------");
            Console.WriteLine("-   Rule of Three  -");
            Console.WriteLine("-     Calculator   -");
            Console.WriteLine("--------------------");
            Console.WriteLine("-   {0}   |    2   -", n1);
            Console.WriteLine("-   3     |    X   -");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.Write("Enter second numer to replace number 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("--------------------");
            Console.WriteLine("-   Rule of Three  -");
            Console.WriteLine("-     Calculator   -");
            Console.WriteLine("--------------------");
            Console.WriteLine("-   {0}   |    {1}  -", n1, n2);
            Console.WriteLine("-   3     |    X   -");
            Console.WriteLine("--------------------");
            Console.WriteLine("");
            Console.Write("Enter third numer to replace number 3: ");
            n3 = float.Parse(Console.ReadLine());
            Console.Clear();

            //Calculator

            result = (n2 * n3) / n1;

            //Result
            Console.Clear();
            Console.WriteLine("--------------------");
            Console.WriteLine("-   Rule of Three  -");
            Console.WriteLine("-     Calculator   -");
            Console.WriteLine("--------------------");
            Console.WriteLine("-   {0}   |    {1}  -", n1, n2);
            Console.WriteLine("-   {0}   |    {1}  -", n3, result);
            Console.WriteLine("--------------------");
            Console.WriteLine("The result is {0}.", result);
            Console.ReadKey();


        }
    }
}