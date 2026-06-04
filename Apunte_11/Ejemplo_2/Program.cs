using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 5;

            Console.WriteLine("\tejemplo recursivo\n");
            ImprimirRecursivo(c);
            Console.WriteLine("\n\n");
            Console.WriteLine("\tejemplo iterativo\n");
            ImprimirIterativo(c);
        }

        #region metodos

        static void ImprimirIterativo(int M)  //ejemplo iterativo 
        {
            for (int n = 0; n <= M; n++)
            {
                Console.WriteLine(n);
            }
        }

        static void ImprimirRecursivo(int N) //ejemplo recursivo
        {
            if (N > 0)
            {
                ImprimirRecursivo(N - 1);
            }
            Console.WriteLine(N);
        }

        #endregion
    }
}
