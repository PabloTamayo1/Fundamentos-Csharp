// See https://aka.ms/new-console-template for more information
// Parte 3
// ---------------------------------------------------
// 1. Verificar si un número es par:

int numero = 7;

// Determinar si es par
if (numero % 2 == 0)

{
    Console.WriteLine("El número es par.");
}
//Caso contrario, significa que es impar
else
{
    Console.WriteLine("El número es impar.");
}

// ---------------------------------------------------
// 2. Verificar si una persona es mayor de edad:

int edad = 25;

if (edad >= 18 && edad > 0)
// Determina si es mayor o igual a 18
{
    Console.WriteLine("Eres mayor de edad.");
}
//Caso contrario, significa que es menor de edad
else
{
    Console.WriteLine("No es mayor de edad o la edad no es valida.");
}

// ---------------------------------------------------
// 3. Verificar si una persona es estudiante universitario:

string TipoEstudiante = "Universitario";

if (TipoEstudiante == "Universitario")
// Determina si es Estudiante Universitario
{
    Console.WriteLine("La persona es estudiante universitario");
}

// ---------------------------------------------------
// 4. Verificar si un número es mayor que cero y menor que diez:

int numeros = 25;

if (numeros > 0 && numeros < 10)
// Determina si es mayor o igual a 18
{
    Console.WriteLine("El numero esta en un rango del 0 al 10.");
}
//Caso contrario, significa que es menor de edad
else
{
    Console.WriteLine("El numero NO esta en un rango del 0 al 10.");
}

// ---------------------------------------------------
// 5. Verificar si un año es bisiesto:

int anio = 2010;

if (anio % 4 == 0)
// Determinar si es divisible para 4, condicion para ser bisiesto
{
    Console.WriteLine("El año es bisiesto.");
}
//Caso contrario, significa que no es bisiesto
else
{
    Console.WriteLine("El año NO es bisiesto.");
}