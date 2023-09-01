using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 0 ao 10");
            Console.Write("Digite um Valor: ");
            string valor = Console.ReadLine();
            int x = int.Parse(valor);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(" " + i + " x " + x + " = " + (i * x));
            }
            Console.WriteLine("10 x " + x + " = " + (x * 10));
            Console.WriteLine("Fim");

            
        }
    }
}
