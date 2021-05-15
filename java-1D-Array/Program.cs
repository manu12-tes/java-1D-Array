using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_1D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de enteros");
            int n = Int32.Parse(Console.ReadLine());
            int[] arreglo = new int[n];

            for (int i = 0; i < n; i++)
                arreglo[i] = Int32.Parse(Console.ReadLine());

            for (int j = 0; j < arreglo.Length; j++)
                Console.WriteLine(arreglo[j]);

        }
    }
}
