// Ejercicio 1: Saludar a un estudiante de la ESPE, y si es un profesor o directivo, cambia el saludo por algo más respetuoso:

Console.WriteLine("Ingrese el rol del individuo (estudiante, profesor o directivo):");
string rol = Console.ReadLine();

if (rol.ToLower() == "estudiante")
{
    Console.WriteLine("¡Hola, estudiante!");
}
else if (rol.ToLower() == "profesor" || rol.ToLower() == "directivo")
{
    Console.WriteLine("¡Buen día, profesor/directivo! Le saludo respetuosamente.");
}
else
{
    Console.WriteLine("Rol no reconocido. Por favor, ingrese un rol válido.");
}

// Ejercicio 2: Programa para calcular la edad, solicitando el año de nacimiento:

Console.WriteLine("Ingrese el año de nacimiento:");
int añoNacimiento = Convert.ToInt32(Console.ReadLine());

int añoActual = DateTime.Now.Year;
int edad = añoActual - añoNacimiento;

Console.WriteLine("La edad es: " + edad);

// Ejercicio 3: Programa para calcular si una persona está perdida o no en el año lectivo, con rangos de edad específicos:

Console.WriteLine("Ingrese la edad de la persona:");
edad = Convert.ToInt32(Console.ReadLine());

if (edad >= 6 && edad <= 18)
{
    Console.WriteLine("La persona está en el año lectivo.");
}
else
{
    Console.WriteLine("La persona está perdida en el año lectivo.");
}

// Ejercicio 4: Programa para calcular el área y perímetro de un rectángulo:

Console.WriteLine("Ingrese la base del rectángulo:");
double ancho = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura del rectángulo:");
double altura = Convert.ToDouble(Console.ReadLine());

double area = ancho * altura;
double perimetro = 2 * (ancho + altura);

Console.WriteLine("El área del rectángulo es: " + area);
Console.WriteLine("El perímetro del rectángulo es: " + perimetro);

// Ejercicio 5: Programa para calcular el área de un círculo:

Console.WriteLine("Ingrese el radio del círculo:");
double radio = Convert.ToDouble(Console.ReadLine());

area = Math.PI * Math.Pow(radio, 2);

Console.WriteLine("El área del círculo es: " + area);