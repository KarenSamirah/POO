using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            char genero = 'M';
            byte num1 = 26;
            string nome = "Joao Bosco";
            Console.WriteLine("{0} tem {1} anos e é do gênero {2}", nome, num1, genero);
            Console.WriteLine($"{nome} tem {num1} anos e é do gênero {genero} ");
            Console.WriteLine(nome + " tem " + num1 + " anos e é do gênero " + genero);
        }
    }
}
