using System;

namespace Programa_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.	Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del segundo.
            int num1;
            int num2;
            int multiplo;
            Console.WriteLine("Poner el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Poner el segundo numero:");
            num2 = int.Parse(Console.ReadLine());
            multiplo = num1 % num2;

            if (multiplo==0)
            {
                Console.WriteLine("El primero es multiplo del segundo");
            }
            else
            {
                Console.WriteLine("El primero no es multiplo del segundo");
            }

        }
    }
}
