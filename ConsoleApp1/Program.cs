/*
Cree un programa en C# que solicite al usuario dos numeros enteros (x, y) y muestre el rango de esos numeros (Los dos incluidos)
de tres maneras diferentes:
    Usando la instruccion for
    Usando la instruccion while
    Usando la instruccion do while
 */

int x, y, guardaValor;

Console.WriteLine("Ingrese el primer numero: ");
x = Convert.ToInt32(Console.ReadLine());
guardaValor = x;
Console.WriteLine("Ingrese el segundo numero: ");
y = Convert.ToInt32(Console.ReadLine());

// usando for
Console.WriteLine("Usando for: ");
for (int i = x; i <= y; i++)
{
    Console.WriteLine(i);
}

// usando while

Console.WriteLine("Usando while: ");
while (x <= y)
{
    Console.WriteLine(x);
    x++;
}

// usando do while

//Use el guardaValor para guardar el valor previo al incremento y solo necesitar de la variable x
Console.WriteLine("Usando do while: ");
x = guardaValor;
do
{
    Console.WriteLine(x);
    x++;
} while (x <= y);
