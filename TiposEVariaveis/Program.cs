using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10;
            int numero2 = 20;
            var soma = numero1 + numero2;
            Console.WriteLine(numero1 + " + " + numero2 + " = " + soma);

            var quadrado1 = new Quadrado();
            quadrado1.lado = 10;
            var quadrado2 = quadrado1;
            quadrado2.lado = 20;
            Console.WriteLine("Quadrado1 = " + quadrado1.lado);
            Console.WriteLine("Quadrado2 = " + quadrado2.lado);
            /*
            No caso quando a cópia do objeto é  alterada, o valor do objeto que foi copiádo 
            tbm foi alterado. Isso pq os dois objetos apontam para o mesmo lugar de memória.
             */
        }
        class Quadrado
        {
            public int lado;
        }
    }
}
