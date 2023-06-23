// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite un número");
string numeroString = Console.ReadLine();

try
{
    int numero = int.Parse(numeroString);
    Console.WriteLine($"Has escrito el número: {numero}");
}
catch(FormatException fx) 
{
    Console.WriteLine("El dato ingresado no es un número");

    #if DEBUG
        Console.WriteLine(fx.Message);
        Console.WriteLine(fx.StackTrace);
    #endif
}
catch (Exception)
{
    Console.WriteLine("Ha ocurrido un error");
}


