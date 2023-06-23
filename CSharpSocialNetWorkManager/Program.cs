// See https://aka.ms/new-console-template for more information
using CSharpSocialNetWorkManager.Models;

var app = new AppManager();

Console.WriteLine($"Bienvenido a {app.AppTitle}");

Console.WriteLine("Redes sociales disponibles");

foreach (var item in app.SocialNetworks)
{
    Console.WriteLine($"{item.Name}");    
}

foreach (var item in app.SocialNetworksWithGroups)
{
    Console.WriteLine($"{item.Name}");
}

Console.WriteLine("Escriba el nombre de la red social a la que desee ingresar");

string socialNetworkName = Console.ReadLine();

foreach (var item in app.SocialNetworks)
{
    if(item.Name.ToLower() == socialNetworkName.ToLower())
    {
        Console.WriteLine($"Nombre: {item.Name}");
        Console.WriteLine($"Descripción: {item.Description}");
        Console.WriteLine($"Año de creación: {item.DateCreated.Year}");
    }
}

foreach (var item in app.SocialNetworksWithGroups)
{
    if (item.Name.ToLower() == socialNetworkName.ToLower())
    {
        Console.WriteLine($"Nombre: {item.Name}");
        Console.WriteLine($"Descripción: {item.Description}");
        Console.WriteLine($"Año de creación: {item.DateCreated.Year}");
    }
}

return;

Console.WriteLine("Por favor ingrese su Nombre");
string name = Console.ReadLine();
Console.WriteLine("Por favor ingrese su Correo");
string email = Console.ReadLine();
Console.WriteLine("Por favor ingrese su Edad");
short age = short.Parse(Console.ReadLine());

var user = new User();
user.Name = name;
user.Email = email;
user.Age = age;

if (user.IsValid())
{
    Console.WriteLine("Sus datos son:");
    Console.WriteLine($"Nombre: {user.Name}");
    Console.WriteLine($"Correo: {user.Email}");
    Console.WriteLine($"Edad: {user.Age}");
    Console.WriteLine($"Estado activo: {user.IsActive}");
}
else
{
    Console.WriteLine("Los datos del usuario no son válidos");

}
