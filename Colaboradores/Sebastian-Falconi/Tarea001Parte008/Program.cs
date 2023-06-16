// See https://aka.ms/new-console-template for more information
// Ejercicio 1: Imprimir los números del 1 al 10
Console.WriteLine("Números del 1 al 10:");
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine();

// Ejercicio 2: Calcular la suma de los números del 1 al 100
int suma = 0;
for (int i = 1; i <= 100; i++)
{
    suma += i;
}
Console.WriteLine("La suma de los números del 1 al 100 es: " + suma);
Console.WriteLine();

// Ejercicio 3: Imprimir los caracteres de un string en orden inverso
string texto = "Hola, mundo!";
Console.WriteLine("El string original es: " + texto);
Console.WriteLine("El string en orden inverso es:");
for (int i = texto.Length - 1; i >= 0; i--)
{
    Console.Write(texto[i]);
}
Console.WriteLine();
Console.WriteLine();

// Ejercicio 4: Calcular el factorial de un número
int numero = 5;
int factorial = 1;
for (int i = 1; i <= numero; i++)
{
    factorial *= i;
}
Console.WriteLine("El factorial de " + numero + " es: " + factorial);
Console.WriteLine();

// Ejercicio 5: Obtener los dígitos de un número en orden inverso
int numero2 = 12345;
Console.WriteLine("Los dígitos de " + numero2 + " en orden inverso son:");
while (numero2 > 0)
{
    int digito = numero2 % 10;
    Console.Write(digito);
    numero2 /= 10;
}
Console.WriteLine();

Console.ReadLine();