using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laçosIterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(i);
            }
            int contador = 3;
            while(contador <10)
            {
                Console.WriteLine(contador);
                contador++;
            }
            //Do .. while
            // Execução garantida pelo menos uma vez!(Executa o bloco primeiro e depois faz o teste de condição)
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 15;
            } while (j < 100);

            // foreach
            // Percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 4 };
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjuntotem valor " + numero );
            }
        }
    }
}
