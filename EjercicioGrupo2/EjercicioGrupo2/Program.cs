using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioGrupo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.Title = "Ejercicio Lab2";
            String Respuesta, Sexo, Nombre;
            int Edad;
            do
            {

                Console.WriteLine("Favor de ingresar su nombre: ");
                Nombre = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Ingrese su Edad: ");
                Edad = int.Parse(Console.ReadLine());
                Console.WriteLine("\nIngrese su sexo (Hombre=H Y Mujer=M):");
                Sexo = Console.ReadLine(); ;
                if (Sexo == "H" || Sexo == "h")
                    Console.WriteLine("El Sr.{0} ha sido registrado", Nombre);
                else if (Sexo == "M" || Sexo == "m")
                    Console.WriteLine("La Sr. {0} ha sido regisrada", Nombre);
                else
                    Console.WriteLine("Dato Incorrecto");
                Console.WriteLine("Desea Continuar (Si/No:");
                Respuesta = Console.ReadLine();
            }
            while (Respuesta != "no" && Respuesta != "No");
            Console.WriteLine("\n");
            Console.WriteLine("Gracias por usar el programa");
            Console.ReadKey();
        }
    }
    }

