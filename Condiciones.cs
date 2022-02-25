using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            

    
            int numeroEntero = int.Parse(Console.ReadLine());

            if (numeroEntero == 7)
                Console.WriteLine("numeroEntero es 7.");
            else if (numeroEntero < 0)
                Console.WriteLine("numeroEntero es negativo");
            else
                Console.WriteLine("numeroEntero no es ningun de los casos programados");


        }
    }
}
