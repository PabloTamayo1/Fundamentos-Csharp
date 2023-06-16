// See https://aka.ms/new-console-template for more information
//1.Imprimir los números del 1 al 10:
Console.WriteLine(" ");
Console.WriteLine("1.Imprimir los números del 1 al 10:");

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
//2.Calcular la suma de los números del 1 al 100:
Console.WriteLine(" ");
Console.WriteLine("2.Calcular la suma de los números del 1 al 100:");

int suma = 0;
for (int i = 1; i <= 100; i++)
{
    suma += i;
}
Console.WriteLine("La suma es: " + suma);
//3.Imprimir los caracteres de un string:
Console.WriteLine(" ");
Console.WriteLine("3.Imprimir los caracteres de un string:");

string texto = "Hola, mundo!";
foreach (char c in texto)
{
    Console.WriteLine(c);
}
//4.Imprimir los números pares del 1 al 20:
Console.WriteLine(" ");
Console.WriteLine("4.Imprimir los números pares del 1 al 20:");

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
//5.Calcular el factorial de un número:
Console.WriteLine(" ");
Console.WriteLine("5.Calcular el factorial de un número:");

int numero = 5;
int factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}
Console.WriteLine("El factorial de " + numero + " es: " + factorial);