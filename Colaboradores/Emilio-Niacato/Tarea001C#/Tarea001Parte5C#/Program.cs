// PARTE 5
// ---------------------------------------------------
// 1. Imprimir los números del 1 al 10:

for (int i = 1; i <= 10; i++)
// Empieza en 0 y termina en 10
// incrementa i en 1 en cada iteración
{
    Console.WriteLine("Numero: " + i);
}

// ---------------------------------------------------
// 2. Calcular la suma de los números del 1 al 100:

int resultado = 1;

for (int j = 2; j <= 100; j++)
// Suma del 2, debido a que empezamos en 1, hasta el 100
{
    resultado = resultado + j;
    // Suma el resultado por j en cada iteración
}

Console.WriteLine("El resultado es: " + resultado);

// ---------------------------------------------------
// 3. Validar la entrada de un número mayor a cero:

int numero;
string entrada;

do
{
    Console.WriteLine("Ingresa un número mayor a cero: ");
    entrada = Console.ReadLine();

} while (!int.TryParse(entrada, out numero) || numero <= 0);

Console.WriteLine("Número mayor a cero ingresado: " + numero);

// ---------------------------------------------------
// 4. Imprimir los caracteres de un string en orden inverso:
string texto = "Esto es un texto";

// Convertimos el string en un array de caracteres
char[] caracteres = texto.ToCharArray();

// Iteramos el array de caracteres en orden inverso
for (int i = caracteres.Length - 1; i >= 0; i--)
{
    // Imprimimos cada carácter
    Console.Write(caracteres[i]);
}

Console.WriteLine();




// ---------------------------------------------------
// 5. Calcular el factorial de un número
Console.WriteLine(" ");
Console.WriteLine("5.Calcular el factorial de un número:");

int numeros = 5;
int factorial = 1;
for (int i = 1; i <= numeros; i++)
{
    factorial *= i;
}
Console.WriteLine("El factorial de " + numeros + " es: " + factorial);







