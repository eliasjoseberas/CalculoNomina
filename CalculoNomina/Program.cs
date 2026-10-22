using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoNomina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomEmpleado;
            byte horasTrabajadas = 0;
            double pagoxHoras = 0;
            double sueldoBruto = 0;

            Console.WriteLine("Ingrese su nombre y apellido");
            nomEmpleado = Console.ReadLine();

            Console.WriteLine("Ingrese las horas trabajadas");
            while (!byte.TryParse(Console.ReadLine(), out horasTrabajadas))
            {
                Console.WriteLine("El valor introducido no es valido, favor de ingresar un valor numerico");
                Console.WriteLine("Intente de nuevo");
            }

            Console.WriteLine("Ingrese el pago por horas");
            while (!double.TryParse(Console.ReadLine(), out pagoxHoras))
            {
                Console.WriteLine("El valor introducido no es valido, favor de ingresar un valor numerico");
                Console.WriteLine("Intente de nuevo");
            }

            sueldoBruto = (horasTrabajadas * pagoxHoras);

            Console.WriteLine("====================================");
            Console.WriteLine("      INFORMACIÓN DEL EMPLEADO       ");
            Console.WriteLine("===================================");

            Console.WriteLine($"Nombre del empleado: {nomEmpleado}");
            Console.WriteLine($"Total de horas trabajadas en el mes: {horasTrabajadas}");
            Console.WriteLine($"Pago por horas: {pagoxHoras}");
            Console.WriteLine($"Sueldo bruto: {sueldoBruto}");

        }
    }
}
