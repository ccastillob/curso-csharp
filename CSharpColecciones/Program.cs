// See https://aka.ms/new-console-template for more information



//COLECCIONES - VECTORES - ARREGLOS



//int[] listaDeNumeros = new int[5] {1,2,3,4,5};

//for (int i = 0; i < listaDeNumeros.Length; i++)
//{
//    Console.WriteLine("Ingrese un número");
//    listaDeNumeros[i] = int.Parse(Console.ReadLine());
//}

////int cantidadNumeros = 0;

////while (cantidadNumeros <= listaDeNumeros.Length - 1)
////{
////    Console.WriteLine($"{listaDeNumeros[cantidadNumeros]}");
////    cantidadNumeros++;
////}

//foreach (int item in listaDeNumeros)
//{
//    Console.WriteLine(item);
//}



//DICCIONARIOS



////var listaDeDatos = new Dictionary<int, int>();
//var listaDeDatos = new Dictionary<string, int>();

//string valorDigitado = "";

//while (valorDigitado != ".")
//{
//    Console.WriteLine("Ingrese número o ingrese . para terminar");
//    valorDigitado = Console.ReadLine();

//    if (valorDigitado != ".")
//    {
//        try
//        {
//            //listaDeDatos.Add(int.Parse(valorDigitado), int.Parse(valorDigitado));
//            listaDeDatos.Add(Guid.NewGuid().ToString(), int.Parse(valorDigitado));
//        }
//        catch (FormatException fx)
//        {
//            Console.WriteLine("El dato ingresado no es un número");
//            Console.WriteLine(fx.Message);
//        }
//        catch (ArgumentException ax)
//        {

//            Console.WriteLine("El dato ingresado ya existe dentro de la colección");
//            Console.WriteLine(ax.Message);
//        }
        
//    }
//}

//foreach (var item in listaDeDatos)
//{
//    Console.WriteLine($"Clave: {item.Key} - Valor: {item.Value}");
//}



// LISTAS



List<short> listaDePorcentajes = new List<short>();
listaDePorcentajes.Add(50);
listaDePorcentajes.Add(30);
listaDePorcentajes.Add(70);

Console.WriteLine($"Mi lista contiene: {listaDePorcentajes.Count} elementos");

Console.WriteLine($"Mi lista contiene 80? {(listaDePorcentajes.Contains(80) ? "Si contiene el número" : "No lo contiene")}");

foreach (var item in listaDePorcentajes)
{
    Console.WriteLine(item);
}