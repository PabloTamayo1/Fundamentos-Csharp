// See https://aka.ms/new-console-template for more information
// Ejercicio 1: Verificar el día de la semana
DateTime hoy = DateTime.Today;
DayOfWeek diaDeLaSemana = hoy.DayOfWeek;
Console.WriteLine("El día de la semana es: " + diaDeLaSemana);

// Ejercicio 2: Verificar el mes del año
int mes = hoy.Month;
Console.WriteLine("El mes del año es: " + mes);

// Ejercicio 3: Calcular el nombre del día de la semana
string nombreDiaDeLaSemana = hoy.ToString("dddd");
Console.WriteLine("El nombre del día de la semana es: " + nombreDiaDeLaSemana);

// Ejercicio 4: Verificar el tipo de empleado
string tipoEmpleado;
Console.WriteLine("Ingrese el tipo de empleado (Administrativo/Contabilidad/Desarrollador): ");
tipoEmpleado = Console.ReadLine();
if(tipoEmpleado == "Administrativo")
{
    Console.WriteLine("Es un usuario Administrativo");
}
else if(tipoEmpleado == "Contabilidad"){
    Console.WriteLine("Es un usuario de Contabilidad");
}
else if (tipoEmpleado == "Desarrollador")
{
    Console.WriteLine("Es un usuario Desarrollador");
}
else
{
    Console.WriteLine("No es un usuario válido");
}
Console.WriteLine("Ingrese el tipo de cliente (Nuevo/Antiguo/Afiliado): ");
tipoEmpleado = Console.ReadLine();

// Ejercicio 5: Calcular el descuento según el tipo de cliente
double descuento = 0.2;
switch (tipoEmpleado)
{
    case "Nuevo":
        descuento    = 0.2;
        break;
    case "Antiguo":
        descuento = 0.1;
        break;
    case "Afiliado":
        descuento = 0.05;
        break;
    default:
        Console.WriteLine("Tipo de empleado inválido");
        break;
}

Console.WriteLine("El descuento para el tipo de empleado " + tipoEmpleado + " es: " + (descuento * 100) + "%");

Console.ReadLine();