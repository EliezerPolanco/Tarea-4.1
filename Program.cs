using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingrese su fecha de nacimiento en el formato (dd/mm/aaaa):");
        string fechaNacimientoTexto = Console.ReadLine();

        DateTime fechaNacimiento;
        bool esFechaValida = DateTime.TryParseExact(fechaNacimientoTexto, "dd/MM/yyyy", null, DateTimeStyles.None, out fechaNacimiento);

        if (esFechaValida)
        {
            string diaSemana = fechaNacimiento.ToString("dddd", new CultureInfo("es-ES"));

            Console.WriteLine($"Naciste un día {diaSemana}.");
        }
        else
        {
            Console.WriteLine("La fecha ingresada no es válida. Asegúrate de utilizar el formato correcto (dd/mm/aaaa).");
        }
    }
}
