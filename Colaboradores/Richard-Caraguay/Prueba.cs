//crear un script que calcule 
using System;

double a = 0;
double b = 0;
double resultado = 0;

Console.WriteLine("Ingres un valor");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingres un valor");
b = Convert.ToDouble(Console.ReadLine());

resultado = a * b;

Console.WriteLine("El resuyltado es" + resultado);