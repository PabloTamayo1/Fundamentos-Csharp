// 1. Verificar si un número es positivo:
int numero = 10;

if (numero > 0)
{
    Console.WriteLine("El número es positivo.");
}
else if (numero == 0)
{
    Console.WriteLine("El número es cero.");
}
else
{
    Console.WriteLine("El número es negativo.");
}
//2. Verificar si un número es par o impar:
int numero1 = 7;

if (numero1 % 2 == 0)
{
    Console.WriteLine("El número es par.");
}
else
{
    Console.WriteLine("El número es impar.");
}
//3. Verificar si una persona es mayor de edad:
int edad = 20;

if (edad >= 18)
{
    Console.WriteLine("La persona es mayor de edad.");
}
else
{
    Console.WriteLine("La persona es menor de edad.");
}
//4. Verificar si una variable es nula:

string texto = null;

if (texto == null)
{
    Console.WriteLine("La variable es nula.");
}
else
{
    Console.WriteLine("La variable no es nula.");
}
//5. Verificar si un estudiante aprobó un examen:


int calificacion = 75;

if (calificacion >= 70)
{
    Console.WriteLine("El estudiante aprobó el examen.");
}
else
{
    Console.WriteLine("El estudiante no aprobó el examen.");
}