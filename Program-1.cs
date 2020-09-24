using System;

namespace Programa_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.	Crear un programa que pida al usuario un numero entero y diga si es par.
            int num1;
            int par;
            Console.WriteLine("Introducir el numero:");
            num1 = int.Parse(Console.ReadLine());
            par = num1 % 2;

            if (par == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("No es par");
            }
        }
    }
}
