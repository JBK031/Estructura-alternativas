using System;

namespace Programa_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //9.	Crear un programa que use el operador condicional para mostrar el valor absoluto de un numero de la siguiente forma: si el numero es positivo, se mostrara tal cual; si es negativo, se mostrara cambiando el signo.
            int num;

            Console.WriteLine("Poner el numero: ");
            num = int.Parse(Console.ReadLine());

            if (num>0)
            {
                Console.WriteLine("No hay que utulizar el valor negativo" + num);
            }else
            {
                Console.WriteLine("El valor absoluto del numero negativo es: " + Math.Abs(num));
                
            }
        }
    }
}
