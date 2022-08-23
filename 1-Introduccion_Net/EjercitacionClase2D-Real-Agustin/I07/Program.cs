using System;

namespace I07
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaIngresada;
            string nombreIngresado;
            int anioTrabajados;
            int cantHorasTrabMes;
            int importeTotalHorasTrabajadasPorCantHora;
            int bonusAntiguedad;
            int importeSinDescuento;
            float Descuento;
            float importeConDescuento;
            string seguir = " ";

            do
            {
                Console.WriteLine("Ingrese el nombre del empleado: ");
                nombreIngresado = Console.ReadLine();

                Console.WriteLine("Ingrese la cantidad de horas del empleado: ");
                while (int.TryParse(Console.ReadLine(), out horaIngresada) == false)
                {
                    Console.WriteLine("Error. Ingrese la cantidad de horas: ");
                }

                Console.WriteLine("Ingrese los anios trabajados del empleado: ");
                while (int.TryParse(Console.ReadLine(), out anioTrabajados) == false)
                {
                    Console.WriteLine("Error. Ingrese los anios trabajados del empleado: ");
                }

                Console.WriteLine("Ingrese el importe por la cantidad de horas trabajadas del empleado: ");
                while (int.TryParse(Console.ReadLine(), out cantHorasTrabMes) == false)
                {
                    Console.WriteLine("Error.Ingrese el importe por la cantidad de horas trabajadas del empleado: ");
                }

                Console.WriteLine("Deseas seguir ingresando empleados: si/no");
                seguir = Console.ReadLine();

                importeTotalHorasTrabajadasPorCantHora = horaIngresada * cantHorasTrabMes;
                bonusAntiguedad = anioTrabajados * 150;
                importeSinDescuento = importeTotalHorasTrabajadasPorCantHora + bonusAntiguedad;
                Descuento = (float)(importeSinDescuento * 0.13);
                importeConDescuento = importeSinDescuento - Descuento;

                Console.WriteLine(" _________________________________________________ ");
                Console.WriteLine("|                                                 | ");
                Console.WriteLine("|             RECIBO DE SUELDO UTN FRA            | ");
                Console.WriteLine("|_________________________________________________| ");
                Console.WriteLine("|                                                 | ");
                Console.WriteLine($"| NOMBRE DEL EMPELADO: {nombreIngresado}         | ");
                Console.WriteLine($"| ANTIGUEDAD EMPLEADO: {anioTrabajados}          | ");
                Console.WriteLine($"| VALOR POR HS TRABAJADAS: {cantHorasTrabMes}    | ");
                Console.WriteLine($"| SUELDO SIN DESCUENTO: {importeSinDescuento}    | ");
                Console.WriteLine($"| SUELDO CON DESCUENTO: {importeConDescuento}    | ");
                Console.WriteLine("|_________________________________________________| ");


            } while (seguir != "no");
        }
    }
}
