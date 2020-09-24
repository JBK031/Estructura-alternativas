using Microsoft.VisualBasic;
using System;

namespace Programa_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //6.	Crear un programa que pida al usuario tres números reales y muestre cual es el mayor de los tres
            int num1;
            int num2;
            int num3;

            Console.WriteLine("Poner el primer numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Poner el segundo numero:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Poner el tercer numero: ");
            num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine("El numero mayor es: " + num1);

            }else if ((num2>num1) && (num2>num3))
            {
                Console.WriteLine("El numero mayor es: " + num2);
            }else
            {
                Console.WriteLine("El numero mayor es: " + num3);
            }
        }
    }
}
