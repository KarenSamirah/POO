using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool presente = false;
            char genero = 'F';
            char letra = '\u0041';
            byte num1 = 126;
            int num2 = 1000;
            int num3 = 2147483647;
            long num4 = 2147483648L;
            float num5 = 2.5f;
            double num6 = 3.8;
            string nome = "Joao Bosco";
            Console.WriteLine("Minhas variáveis:");
            Console.WriteLine(nome);
            Console.WriteLine(presente);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
        }
    }
}
