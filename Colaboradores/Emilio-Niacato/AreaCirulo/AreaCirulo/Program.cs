// See https://aka.ms/new-console-template for more information
//Crear un script que calcule el area de un circulo

using System;

double radio = 0;
double resultado = 0;

Console.WriteLine("Por favor ingrese el valor del radio");
radio = Convert.ToInt32(Console.ReadLine());

resultado = System.Math.PI * radio * radio;

Console.WriteLine("El resultado es: " + resultado);