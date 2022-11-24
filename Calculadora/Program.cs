using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha;

            Console.Clear();
            Console.Write("====================\n");
            Console.Write(" C# Calculator v1.0 \n");
            Console.Write("====================\n");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("====================\n");
            Console.Write("      Operações     \n");
            Console.Write("====================\n");
            Console.Write("1-Adição       2-Sub\n");
            Console.Write("3-Divisão    4-Multi\n");
            Console.Write("====================\n");
            Console.Write("Opção: ");
            escolha = int.Parse(Console.ReadLine());


        }
    }
}