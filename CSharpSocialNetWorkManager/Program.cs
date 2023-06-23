// See https://aka.ms/new-console-template for more information
using CSharpSocialNetWorkManager.Models;
using System.Linq;

var app = new AppManager();

Console.WriteLine($"Bienvenido a {app.AppTitle}");

while(true)
{

Console.WriteLine("Redes sociales disponibles");

foreach (var item in app.SocialNetworks.Concat(app.SocialNetworksWithGroups))
{
    Console.WriteLine($"{item.Name}");
}

Console.WriteLine("Escriba el nombre de la red social a la que desee ingresar");

string socialNetworkName = Console.ReadLine();


var socialNetworkSelected = app.SocialNetworks.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName.ToLower());

Console.Write(app.GetSocialNetworkInformation(socialNetworkSelected));

var socialNetworkWithGroupsSelected = app.SocialNetworksWithGroups.FirstOrDefault(p => p.Name.ToLower() == socialNetworkName.ToLower());

Console.Write(app.GetSocialNetworkInformation(socialNetworkWithGroupsSelected));

Console.WriteLine("");
Console.WriteLine("1=Agregar nuevo usuario, 2=Para las estadisticas");

    var optionSelected = int.Parse(Console.ReadLine());

    switch (optionSelected)
    {
        case 1:
            {
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

                if (socialNetworkSelected != null)
                {
                    int indexElement = app.SocialNetworks.IndexOf(socialNetworkSelected);
                    app.SocialNetworks[indexElement].Users.Add(user);
                }

                if (socialNetworkWithGroupsSelected != null)
                {
                    int indexElement = app.SocialNetworksWithGroups.IndexOf(socialNetworkWithGroupsSelected);
                    app.SocialNetworksWithGroups[indexElement].Users.Add(user);
                }
            }
            break;
            case 2:
            if (socialNetworkSelected != null)
                Console.WriteLine(app.GetSocialNetworkStats(socialNetworkSelected));
            if (socialNetworkWithGroupsSelected != null)
                Console.WriteLine(app.GetSocialNetworkStats(socialNetworkWithGroupsSelected));
            break;
    }



}
