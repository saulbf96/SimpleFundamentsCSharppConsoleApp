// See https://aka.ms/new-console-template for more information

using System.Globalization;

Console.WriteLine("Basi console");

//llamamos al metodo 
//GetUserData();
//GetFormatNumericalData();
//LocalVariableDeclaracion();
//LocalVarDeclarations();
//EjemploLinq();
ForLoopExample();
Console.ReadLine();

//-------------USANDO EL FOR LOOP-------------------------
static void ForLoopExample()
{
    //simple for loop
    //------NOTA i solo es visible dentro del bucle for 
    /*
     * 
     * se usa para ejecutar un
     * bloque de código repetidamente mientras se cumpla una 
     * condición específica. Es útil cuando sabes cuántas 
     * veces quieres repetir una acción.
     for (inicialización; condición; actualización)
 {
     // Código a ejecutar en cada iteración
 }
     */
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine($"numero es: {i}");
    }
}


//*******************************************************************************
static void EjemploLinq()
{
    //array de n numeros 
    int[] numeros = { 10, 20, 30, 40, 1, 2, 3, 8 };
    //linq query

    var subset =
        from i in numeros
        where i < 10
        select i;
    Console.WriteLine(" Valores en subset");

    // recorremos el array 
    foreach ( var i in subset )
    {
        Console.WriteLine("{0}", i);
    }

    Console.WriteLine("subset es:{0}",subset.GetType().Name);
    Console.WriteLine("subset es definido en: {0}",subset.GetType().Namespace);
           
}

//*****************************************************************
static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");
    int myInt = 0;
    string myString;
    myString = "This is my character data";
    // Declare 3 bools on a single line.
    bool b1 = true, b2 = false, b3 = b1;
    Console.WriteLine();
}
//*************************************************
Console.WriteLine("Tipo de datos basicos ");
static void LocalVariableDeclaracion()
{
    Console.WriteLine("=> Datos declaracion");
    // variables locales se declaran con tipo y nombre 
    //int miNumero;
    //string mytexto;

    // es un error no declarar las variablees cuando se declara
    int numero = 0;
    string miTexto = "hola";



}



// declaracion de variables e inicialisacion 
// ahora llamaremos una funcion 

//*****************************************************************
static void GetUserData()
{
    //Obtenermos nombre 
    Console.WriteLine("Inserte su nombre porfavor");

    // declaramos variable 
    string userName = Console.ReadLine();
    Console.WriteLine("Ingresa tu edad");

    string userAge = Console.ReadLine();

    //cambiar de color solo por que si 
    ConsoleColor prevColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Yellow;

    // enviamos respuesta 

    Console.WriteLine($"Hola {userName} tu tienes {userAge} años ");

    //reiniciar colores 

    Console.ForegroundColor = prevColor;

    //metodo para el formato de numeros 
}
    static void GetFormatNumericalData()
    {
        Console.WriteLine(" el valor de 99999 en varios formatos");
        Console.WriteLine(" c formato: {0:c}", 99999);
        Console.WriteLine(" d9 formato: {0:d9}", 99999);
        Console.WriteLine(" f3 formato: {0:f3}", 99999);
        Console.WriteLine(" n formato: {0:n}", 99999);

        // tener en cuenta que   el uso de mayusculas y minisculas en exadecimal
        //determinar si las letras estan en mayuasculas o minusculas

        Console.WriteLine(" E formato: {0:E}", 99999);
        Console.WriteLine(" e formato: {0:e}", 99999);
        Console.WriteLine(" X formato: {0:X}", 99999);
        Console.WriteLine(" x formato: {0:x}", 99999);
    }

