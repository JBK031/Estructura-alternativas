using System;

namespace Programa_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.	Crear un programa que pida al usuario dos números enteros. Si el segundo no es cero, mostrara el resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo numero es cero, escribirá “Error: No se puede dividir entre cero”
            int num1;
            int num2;

            Console.WriteLine("Poner el primer numero:  ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Poner el segundo numero:  ");
            num2 = int.Parse(Console.ReadLine());

            if (num2 !=0)
            {
                int resultado = num1 / num2;
                Console.WriteLine("El resultado de la division de los dos numeros es:   " + resultado);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre 0");
            }
        }
    }
}
