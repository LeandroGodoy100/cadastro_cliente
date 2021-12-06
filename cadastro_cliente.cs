using System;

namespace Leandro
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, soma;

           n = int.Parse(Console.ReadLine());
           soma = 0;

           for (int i = 0; i < n; i++)
           {
               soma = soma + 2;
               Console.WriteLine("Valor de i = "+ i);
               Console.WriteLine("Resultado da Multiplicação = "+ soma);
           }
        }
    }
}
