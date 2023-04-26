using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;

            Console.Write("digita o primeiro numero: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("digite o segundo numero: ");

            n2 = double.Parse(Console.ReadLine());
            
                if (n1 == n2)

                Console.WriteLine("os numeros são iguais.");
            
            else         
            
                if (n1 > n2)

                Console.WriteLine("o primeiro é maior que o segundo."); 
            
            else
            Console.WriteLine("o segundo e maior que o primeiro.");
            
        }
    }
}
