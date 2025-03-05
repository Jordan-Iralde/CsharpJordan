Console.WriteLine("Ingrese el lado 1: ");
int Lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el lado 2: ");
int Lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el lado 3: ");
int Lado3 = Convert.ToInt32(Console.ReadLine()); //Hipotenusa

double Area = (base * altura) / 2;
double Perimetro = Lado1 + Lado2 + Lado3;

Console.WriteLine($"El área del triángulo equilátero es: {Area} y el perimetro es: {Perimetro}");
