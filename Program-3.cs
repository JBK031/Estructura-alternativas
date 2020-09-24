using System;

namespace Programa_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.	Crear un programa que pida al usuario un numero entero. Si es múltiplo de 10, se lo avisará y pedirá un segundo numero, para decir a continuación si este segundo numero también es múltiplo de 10.
            int num1;
            int multiplo;
            Console.WriteLine("Poner el numero:");
            num1 = int.Parse(Console.ReadLine());
            multiplo = num1 % 10;

            if(multiplo==0)
            {
                Console.WriteLine("Es multiplo de 10");
                int num2;
                int multi;
                Console.WriteLine("Poner el segundo numero:");
                num2 = int.Parse(Console.ReadLine());
                multi = num2 % 10;
                if (multi==0)
                {
                    Console.WriteLine("Los dos numeros son multiplo de 10");

                }
                else
                {
                    Console.WriteLine("El primero es multiplo de 10 y el segundo no");
                }


            }
            else
            {
                Console.WriteLine("No es multiplo de 10");
            }
        }
    }
}
