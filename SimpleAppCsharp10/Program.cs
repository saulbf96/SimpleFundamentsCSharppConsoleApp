// See https://aka.ms/new-console-template for more information

using System.Globalization;

//-------Estructuras de Programación-----------
//llamamos al metodo 
//GetUserData();
//GetFormatNumericalData();
//LocalVariableDeclaracion();
//LocalVarDeclarations();
//EjemploLinq();
//ForLoopExample();
//ForEachLoopExaple();
//WhileLoopExample();
//DoWhileLoopExample();
//SwitchExample();
//SimpleArray();
//JaggedMultidimensionalArray();
//-----------------------Understanding Methods-------------------------------
Console.ReadLine();

//-----------------------------------Understanding Methods----------------------------




//------Array multidimencional-------------------------------

static void JaggedMultidimensionalArray()
{
    Console.WriteLine("Array multidemencional ");
    //Aqui tenemos un arrat de diferentesn arrays

    int[][] myJagArray = new int[5][];
    
    //crear el jaded array 
    for (int i = 0; i<myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }

    //imprimir cada uno row

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.WriteLine(myJagArray[i][j] + " ");

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}




//----------TRABAJANDO CON ARRAYS----------------------
/*Como probablemente ya sabes, un arreglo es un conjunto de elementos de datos a 
 * los que se accede mediante un índice numérico. Más específicamente, un arreglo 
 * es un conjunto de puntos de datos contiguos del mismo tipo
 * UN ARREGLO SIEMPRE EMPIZA CON INDEX DE 0 EN ADELANTE SI DECLARO UN ARRAY DE 3 
 * MI INDEX ES 0,1,2
 */
static void SimpleArray()
{
    Console.WriteLine("Simple array ");
    //creacion array de tres integres

    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;

    //Now print each value
    foreach (int item in myInts)
    {
        Console.WriteLine(item);

    }
    Console.WriteLine();

}



//switch 
/*Si se incluyera algún código entre las declaraciones case, 
 * el compilador generaría un error. Siempre que sean declaraciones
 * consecutivas, como se mostró antes, los case pueden combinarse 
 * para compartir código común.
 
 */

// Usando swicht------------------------------------

static void SwitchExample()
{
    Console.WriteLine(" 1 [C#], 2 [VB]");
    Console.WriteLine("Ingresa tu lenguaje preferido");

    string langChoice = Console.ReadLine();
    int n = int.Parse(langChoice);
    
    //entra el switch
    switch (n)
    {
        case 1:
            Console.WriteLine("Buena eleccion, C# es buen lenguaje");
            break;
        case 2:
            Console.WriteLine("Buena eleccion VB es buen lenguaje");
            break;
        default:
            Console.WriteLine(" muy bien tienes otros gustos");
            break;
    }
}





//usi de bucle do-while------------------
/*
 * do/while se usa cuando necesitas realizar una acción 
 * un número indeterminado de veces.
 */
static void DoWhileLoopExample()
{
    string userIDone = "";
    do
    {
        Console.WriteLine("In do while loop");
        Console.WriteLine(" Estas tu listo?");
        Console.WriteLine("[yes] [no]");
        userIDone = Console.ReadLine();

    } while (userIDone.ToLower() != "yes"); 
}





//Uso de bucles while y do while 

/*La construcción de bucle while es útil cuando deseas ejecutar
un bloque de instrucciones hasta que se alcance una condición de
terminación. Dentro del alcance de un bucle while, debes asegurarte 
de que este evento de terminación realmente ocurra; de lo contrario, 
quedarás atrapado en un bucle infinito.
 * 
 */

static void WhileLoopExample()
{
    string userIsDone = "";
    //prueba de una copia en minusculas de la cadena 
    while (userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("en While LOOP");
        Console.WriteLine("Estas tu listo? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    }

}

//---------------USANDO FOREACH------------------------

//Iterar elementos de un arreglo usando foreach.

static void ForEachLoopExaple()
{
    //un array string para recorrer
    string[] carTypes = { "Ford", "Nissan", "Byd", "Kia" };
     foreach (var c in carTypes)
    {
        Console.WriteLine(c);
    }
    int[] myInts = { 10, 20, 30 };

    foreach (var c in myInts)
    {
        Console.WriteLine(c);
    }
}

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