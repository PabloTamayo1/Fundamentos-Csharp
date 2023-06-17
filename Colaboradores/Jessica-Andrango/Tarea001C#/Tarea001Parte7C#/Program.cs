// See https://aka.ms/new-console-template for more information
// Ejercicio 1: Verificar el día de la semana
DateTime fechaActual = DateTime.Today;
DayOfWeek diaSemana = fechaActual.DayOfWeek;
Console.WriteLine("Hoy es: " + diaSemana);
Console.WriteLine();

// Ejercicio 2: Verificar el mes del año
int mesActual = fechaActual.Month;
Console.WriteLine("El mes actual es: " + mesActual);
Console.WriteLine();

// Ejercicio 3: Calcular el nombre del día de la semana
string nombreDiaSemana = fechaActual.ToString("dddd");
Console.WriteLine("El día de la semana es: " + nombreDiaSemana);
Console.WriteLine();

// Ejercicio 4: Verificar el tipo de empleado
string tipoEmpleado;
Console.WriteLine("Ingrese el tipo de empleado (Gerente/Vendedor/Recepcionista): ");
tipoEmpleado = Console.ReadLine();

switch (tipoEmpleado)
{
    case "Gerente":
        Console.WriteLine("Es un empleado de tipo gerente");
        break;
    case "Vendedor":
        Console.WriteLine("Es un empleado de tipo vendedor");
        break;
    case "Recepcionista":
        Console.WriteLine("Es un empleado de tipo recepcionista");
        break;
    default:
        Console.WriteLine("No es un tipo de empleado válido");
        break;
}
Console.WriteLine();

// Ejercicio 5: Calcular el descuento según el tipo de cliente
string tipoCliente;
Console.WriteLine("Ingrese el tipo de cliente (Regular/Oro/Platino): ");
tipoCliente = Console.ReadLine();

double descuento = 0.0;

switch (tipoCliente)
{
    case "Regular":
        descuento = 0.1;
        break;
    case "Oro":
        descuento = 0.2;
        break;
    case "Platino":
        descuento = 0.3;
        break;
    default:
        Console.WriteLine("Tipo de cliente inválido");
        break;
}

Console.WriteLine("El descuento para el tipo de cliente " + tipoCliente + " es del " + (descuento * 100) + "%");

Console.ReadLine();
