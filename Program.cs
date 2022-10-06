using System;

namespace Actividad_5__Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int n;


            Console.WriteLine("Ingrese el numero a factorizar");
            n = Convert.ToInt32(Console.ReadLine());
            formula(n);
            Console.WriteLine("El factorial de {0} es {1}", n, formula(n));
            
        }
        static int formula(int n)
        {
            int i,f;
            f = 1;
            for (i = 1; i <= n; i++)
            {
                f = f * i;
            }
            return f;
        }
    }
}
