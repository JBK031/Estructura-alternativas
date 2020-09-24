using System;

namespace Programa_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //10.	Usar el operador condicional para calcular el menor de dos números.
            int num1;
            int num2;

            Console.WriteLine("Poner el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Poner el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1<num2)
            {
                Console.WriteLine("El menor de esos dos numeros :" + num1);
            }
            else
            {
                Console.WriteLine("El menor de esos dos numero:  " + num2);
            }
        }
    }
}
