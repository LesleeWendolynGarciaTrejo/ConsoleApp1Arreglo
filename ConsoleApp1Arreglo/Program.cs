using System;

namespace ConsoleAppArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calificaciones a = new Calificaciones();
            Calificaciones[] arregloCalificaciones = new Calificaciones[5];
            for (int i = 0; i < arregloCalificaciones.Length; i++)
            {
                arregloCalificaciones[i] = new Calificaciones();
                Console.WriteLine(" Nombre");
                arregloCalificaciones[i].Nombre = "";
                arregloCalificaciones[i].Nombre = Console.ReadLine();
                Console.WriteLine("Apellidos");
                arregloCalificaciones[i].Apellidos = "";
                arregloCalificaciones[i].Apellidos = Console.ReadLine();
                Console.WriteLine("Promedio");
                arregloCalificaciones[i].Promedio = "";
                arregloCalificaciones[i].Promedio = Console.ReadLine();
            }
            for (int i = 0; i < arregloCalificaciones.Length; i++)
            {
                Console.WriteLine(arregloCalificaciones[i].ToString());
            }
            Console.ReadKey();
        }
    }

}
