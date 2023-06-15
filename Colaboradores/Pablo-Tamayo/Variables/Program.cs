// See https://aka.ms/new-console-template for more information

// Crear un script que calcule el area de un rectangulo

using System;

double a = 0;
double b = 0;
double resultado = 0;

Console.WriteLine("Por favor ingrese un valor");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
b = Convert.ToDouble(Console.ReadLine());

resultado = a * b;

Console.WriteLine("El resultado es: " + resultado);

//1.Declarar una variable de tipo int:
int num1 = 4;

//2.Declarar una variable de tipo double:
double num2 = 0;

//3.Declarar una variable de tipo string:
string cadena = "Nombre";

//4.Declarar una variable utilizando la palabra clave var:
var variable= "usando un var";

//5.Declarar una variable de tipo boolean:
bool accion = true;

//Parte 4:
//1.Suma de dos números enteros:
int nm1= 0;
int nm2 = 0;
int resulint = 0;

Console.WriteLine("Por favor ingrese un valor");
nm1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
nm2 = Convert.ToInt32(Console.ReadLine());

resulint = nm1 + nm2;

Console.WriteLine("El resultado es: " + resulint);

//2.Resta de dos números de punto flotante:
float nm3 = 0;
float nm4 = 0;
float resulfloat = 0;

Console.WriteLine("Por favor ingrese un valor");
nm3 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
nm4 = Convert.ToSingle(Console.ReadLine());

resulfloat = nm3 - nm4;

Console.WriteLine("El resultado es: " + resulfloat);

//3.Multiplicación de dos números enteros:
int nm5 = 0;
int nm6 = 0;
int resulint2 = 0;

Console.WriteLine("Por favor ingrese un valor");
nm5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
nm6 = Convert.ToInt32(Console.ReadLine());

resulint2 = nm5 * nm6;

Console.WriteLine("El resultado es: " + resulint2);

//4.División de dos números de punto flotante:
float nm7 = 0;
float nm8 = 0;
float resulfloat2 = 0;

Console.WriteLine("Por favor ingrese un valor");
nm7 = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
nm8 = Convert.ToSingle(Console.ReadLine());

resulfloat2 = nm7 / nm8;

Console.WriteLine("El resultado es: " + resulfloat2);

//5.Módulo de dos números enteros:
int nm9 = 0;
int nm10 = 0;
int resulint3 = 0;

Console.WriteLine("Por favor ingrese un valor");
nm9 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Por favor ingrese un valor");
nm10 = Convert.ToInt32(Console.ReadLine());

resulint3 = nm9 % nm10;

Console.WriteLine("El resultado es: " + resulint3);
