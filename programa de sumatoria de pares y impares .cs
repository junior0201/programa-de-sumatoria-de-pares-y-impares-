using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, pares = 0, impares = 0;
            Console.WriteLine("Desarrolladores.");
            Console.WriteLine(" Willy Junior - 14-SISM-1-013");
            Console.WriteLine(" Jonal Geraldo - 15-EIST-1-089");
            Console.WriteLine(" Melkis Rodriguez - 15-EIST-1-040");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Ingrese la longitud del array para luego completar");
            Console.Write("Cantidad: ");
        
        num = int.Parse(Console.ReadLine());
            int[] array1 = new int[num];
            for (int i = 0; i < num; i++)
            {
            
            Console.Write("Numero {0}: ", i + 1);
                array1[i] = int.Parse(Console.ReadLine());
                if (array1[i] % 2 == 0)
                    
            {
                    pares = pares + array1[i];
                }
                else
                {
                    impares = impares + array1[i];
                }
            }
            Console.WriteLine("La suma de los numeros pares ingresados es " + pares + " y la de los numeros impares es " + impares);
        
        Console.ReadKey();

        }
    }
}
