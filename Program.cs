using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicaarreglo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool encontrado = false; // Una miskey herramienta misteriosa que nos será util en un futuro
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; // Generamos un arreglo de 10 elementos con valores del 1 al 10
            foreach (int i in arreglo) // Imprime el arreglo
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            arreglo[2] = 99; // Cambiamos el valor del tercer elemento del arreglo a 99
            foreach (int i in arreglo) // Imprime el arreglo con el cambio realizado
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Introduzca el valor que busca"); // Solicitamos al usuario un valor a buscar
            int x = int.Parse(Console.ReadLine()); // Guardamos el valor en la variable x
            for (int i = 0; i < arreglo.Length; i++) 
            {
                if (arreglo[i] == x)
                {
                    Console.WriteLine("El valor " + x + " se encuentra en la posición " + i); // Si el valor se encuentra en el arreglo, se imprime la posición
                    encontrado = true;
                    break;
                }
            }
            if (encontrado == false)
            {
                Console.WriteLine("El valor " + x + " no se encuentra en el arreglo"); // Si el valor no se encuentra en el arreglo, se imprime 
            }
        }
    }
}