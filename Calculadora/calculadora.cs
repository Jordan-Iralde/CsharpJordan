
while (true){
    Console.WriteLine("Ingrese un numero a: ");
    int a = Convert.ToInt32(Console.ReadLine()); //Esto para numeros

    Console.WriteLine("Ingrese un numero b: ");
    int b = Convert.ToInt32(Console.ReadLine()); //Esto para numeros


    Console.WriteLine("1- Suma \n 2- Resta \n 3- Division \n 4- Multiplicacion ");

    int Eleccion = Convert.ToInt32(Console.ReadLine()); //Esto es la eleccion

    if (Eleccion == 1){
        Console.WriteLine("Funciona");
    } else{
        Console.WriteLine("Error");
    }
}
