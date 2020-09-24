using System;

namespace Programas_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.	Crear un programa que pida al usuario dos números enteros cortos y diga si son iguales o, en caso contrario, cual es el mayor de ellos.
            int num1;
            int num2;

            Console.WriteLine("Poner el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Poner el segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("El mayor de los dos numeros es:  " + num1);
                }
                else
                {
                    Console.WriteLine("El mayor de los dos numero es:  " + num2);
                }
            }
        }
    }
}
