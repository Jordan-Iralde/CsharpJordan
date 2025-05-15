// 1- Hacer un programa que lea 3 notas y calcule el promedio.

Console.WriteLine("Ingrese la primera nota");
int Numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la segunda nota");
int Numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la tercera nota");
int Numero3 = Convert.ToInt32(Console.ReadLine());

double Promedio = (Numero1 + Numero2 + Numero3) / 3;

Console.WriteLine("El promedio de las notas es: " + Promedio);



// 2- Un videoclub cobra $5000 por película, el usuario deberá ingresar cuantas
// películas quiere y luego mostrar el importe total a pagar.

Console.WriteLine("Ingrese la cantidad de peliculas para llevar: ");
int CantidadPeliculas = Convert.ToInt32(Console.ReadLine());
int Precio = 5000;

Console.WriteLine($"Se lleva {CantidadPeliculas} con un precio de {Precio}, es un total de " + CantidadPeliculas * Precio);



// 3 - Realizar un programa que calcule el área y perímetro de un triángulo equilátero.
// Area= Base * Altura/2
// Perímetro = lado + lado + lado

Console.WriteLine("Ingrese uno de los lados: ");
int TrianguloEquilatero = Convert.ToInt32(Console.ReadLine());

double Area = (TrianguloEquilatero * TrianguloEquilatero) / 2;
double Perimetro = TrianguloEquilatero * 3

Console.WriteLine($"El área del triángulo equilátero es: {Area} y el perimetro es: {Perimetro}");




// Hacer el mismo programa pero un triangulo no equilátero.

Console.WriteLine("Ingrese el lado 1: ");
int Lado1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el lado 2: ");
int Lado2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el lado 3: ");
int Lado3 = Convert.ToInt32(Console.ReadLine()); //Hipotenusa

double Area = (Lado1 * Lado2) / 2;
double Perimetro = Lado1 + Lado2 + Lado3;

Console.WriteLine($"El área del triángulo equilátero es: {Area} y el perimetro es: {Perimetro}");



//5- Programa que calcule el salario de un obrero si tuvo el 25% de aumento, sobre el
// salario anterior. Mostrar por consola (salario anterior, aumento, salario Actual)

Console.WriteLine("Ingrese su salario: ");
int Salario = Convert.ToInt32(Console.ReadLine());
int Aumento = Salario * 25 / 100;
Console.WriteLine($"Su salario anterior es: {Salario}");
Console.WriteLine($"Su aumento es: {Aumento}");
Console.WriteLine($"Su salario actual es: {Salario + Aumento}");



/* 6- El programa debe calcular el monto que recibirá cada área del hospital
(Ginecología, Pediatría, y Traumatología) según un presupuesto total ingresado. La
distribución del presupuesto es:
● Ginecología: 40%
● Pediatría: 30%
● Traumatología: 30%
*/

Console.WriteLine("Presupuesto total: ");
int Presupuesto = Convert.ToInt32(Console.ReadLine());
int Ginecologia = Presupuesto * 40 / 100;
int Pediatria = Presupuesto * 30 / 100;
int Traumatologia = Presupuesto * 30 / 100;
Console.WriteLine($"Ginecologia: {Ginecologia}, Pediatria: {Pediatria}, Traumatologia: {Traumatologia}");

//7- TODOS LOS LUNES MIÉRCOLES Y VIERNES UNA PERSONA CORRE LA
//MISMA RUTA Y CRONOMETRA LOS TIEMPOS. MOSTRAR EL PROMEDIO DE LA //SEMANA.

Console.WriteLine("Tiempo de los lunes");
int Lunes = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tiempo de los miercoles");
int Miercoles = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Tiempo de los viernes");
int Viernes = Convert.ToInt32(Console.ReadLine());

double PromedioSemanal = (Lunes + Miercoles + Viernes) / 3;
Console.WriteLine("El promedio de la semana es: " + PromedioSemanal);



//8- Programa que calcule la temperatura en grados celsius a Fahrenheit
// Fórmula: Fahrenheit = (Celsius * 9 / 5) + 32

Console.WriteLine("Convertir Celsius a farenheit");
int Celsius = Convert.ToInt32(Console.ReadLine());
// Formula Celsius a Farenheit = (C * 1.8) + 32;
// Formula Farenheit a Celsius = (F - 32) / 1.8
double Farenheit = (Celsius * 9/5) + 32;
Console.WriteLine($"{Celsius} Grados es igual a {Farenheit} Farenheit");



//9 - Programa que ingrese el precio del producto y un porcentaje de descuento, y se
// muestra el precio final.

Console.WriteLine("Ingrese el precio del producto: ");
int Precio = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el descuento: ");
int Descuento = Convert.ToInt32(Console.ReadLine());

int PrecioFinal = Precio - (Precio * Descuento / 100);
Console.WriteLine(PrecioFinal);




// 10 - Se ingresa un número de días y se muestra cuántas semanas y días completos
// representa.

Console.WriteLine("Ingrese los numeros de dias: ");
int dias = Convert.ToInt32(Console.ReadLine());
int semanas = dias / 7;
int diasRestantes = dias % 7;

Console.WriteLine($"Dias: {dias}, Semanas: {semanas} con {diasRestantes} dias");

