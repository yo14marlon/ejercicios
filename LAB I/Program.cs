using Lab1.Entidades;

Persona1 persona0 = new Persona0();

Console.WriteLine("Ingresa tu altura en metro: ");
double altura0 = double.Parse(Console.ReadLine());

Console.WriteLine("\nIngresa el peso en kg: ");
double peso0 = double.Parse(Console.ReadLine());

persona0.calcularIMC(peso0, altura0);


Console.WriteLine("\nIngrese su nombre: ");
string Nombre0 = Console.ReadLine();

Console.WriteLine("\nIngresa el sexo: ");
string Sexo0 = Console.ReadLine();

Console.WriteLine("\nIngresa la edad: ");
int Edad0= Int32.Parse(Console.ReadLine());

persona0.EsMayordeEdad(Edad0, Nombre0, Sexo0);

