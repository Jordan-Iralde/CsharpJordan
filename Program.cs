
Console.WriteLine("Hello, World!"); //print

//Comentario
/*
Tipos de Datos:
Todo lo mismo C++

if/for/while/switch/TODO LO MISMO

76 palabras reservadas

No es automatico, 

*/

Console.WriteLine("Ingrese caracter");
//Console.ReadLine(); //Input como string
//int a = Convert.ToInt32(Console.ReadLine()); //Esto para numeros


/*
while(true)             //Asi se escribe un while
{
    ConsoleKeyInfo key = Console.ReadKey();     //Para un teclado

    if (key.Key == ConsoleKey.O)
    {
        Console.WriteLine("hol");
    }
    else
    {
        Console.WriteLine("a");
    }
}
*/

string[] cars;      //row 1         //row 2
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

List<Tabla> list = new List<Tabla> {
    new Tabla{id = 1, Name = "Pepeortiva"}
};   //Asi se escribe un vector de CPP

Console.WriteLine(list[0].Name);
Console.WriteLine(list[0].id); //Para cada elemento?

//-> Herencia           class Tabla() 
// Clases publicas privadas, interfaces

public class Tabla
{
    //Parametros
    //En las clases no van punto y coma
    public int id { get; set; }

    public string ? Name { get; set; } //Esto es importante, cuando esta no tiene que ser nulo = ?

}