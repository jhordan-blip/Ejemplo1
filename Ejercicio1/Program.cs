using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // solicitar e imprimir el nimbre, la edad y la estaturas de
            // un alumno.
            //ademas mostrar en que año nacio.

            // ENTRADA (declarar variables)
            string nombre;
            int edad;
            float estatura;
            int aniodenacimiento;

            // PROCESO 
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.Beep(1000,500);
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            Console.Beep(1000, 700);
            Console.WriteLine("Ingrese su estatura:");
            Console.Beep(1000, 1000);
            estatura = float.Parse(Console.ReadLine());
            

            aniodenacimiento = 2025 - edad;

            // SALIDA

            Console.WriteLine("");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Bienvenido!!!!! ");
            Console.WriteLine("");
            Console.WriteLine("Su nombre es: " + (nombre));
            Console.WriteLine("");
            Console.WriteLine("Su edad es: " + (edad));
            Console.WriteLine("");
            Console.WriteLine("Su estatura es: " + (estatura));
            Console.WriteLine("");
            Console.WriteLine("Su año de nacimiento es:" + (aniodenacimiento));


            // Detener la pantalla 
            Console.ReadLine(); 
        }
    }
}
