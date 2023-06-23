// See https://aka.ms/new-console-template for more information
//for(int i=0; i<=5; i++ )
//{
//    Console.WriteLine( i );
//}

//for (int i = 5; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}

int contador = 0;

while (contador <= 5)
{
    Console.WriteLine($"El contador es: {contador}");
    contador++;
    //contador+= 1;
    //contador = contador + 1;
}

foreach (var item in new [] {5,4,3,2,1,0})
{
    Console.WriteLine(item);
}