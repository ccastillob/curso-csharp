// See https://aka.ms/new-console-template for more information
using CursoCsharp.Enumerations;

#region variables

const string nombre = "CriSs";
var apellido = "Creative";

apellido = "Creative Destiny";
short edad = 29;
Int16 altura = 174;
//float alturaEnMetros = float.Parse((1.74).ToString());
float alturaEnMetros = 1.74f;

#endregion

Console.WriteLine("Hola " + nombre + " " + apellido);

Console.WriteLine(string.Format("Mi nombre tiene {0} letras", nombre.Length));

Console.WriteLine($"Mi apellido tiene {apellido.Trim().Replace(" ", "").Length} letras");

Console.WriteLine($"Mi edad es: {edad}");

Console.WriteLine($"Mi altura es: {altura} cm");

Console.WriteLine($"Mi altura en metros es: {alturaEnMetros}cm");

DateTime fechaNacimiento = new DateTime(1993,10,17);
var fechaActual = DateTime.Now;

//Console.WriteLine($"Mi fecha de nacimiento es: {fechaNacimiento.Date.ToShortDateString()}");
Console.WriteLine($"Mi fecha de nacimiento es: {fechaNacimiento.Date.ToString("MM/dd/yy")}");

Console.WriteLine($"La fecha actual es: {fechaActual}");

var diferenciaDeFechas = fechaActual - fechaNacimiento;

Console.WriteLine($"Mi edad de acuerdo a mi fecha de nacimiento es: {diferenciaDeFechas.Days / 365}");

var miGenero = Genero.Masculino;

Console.WriteLine($"Mi genero es: {miGenero}");

var miEstadoCivil = EstadoCivil.Soltero;

Console.WriteLine($"Mi estado civil es: {miEstadoCivil}");

DateTime? fechaTerminacionCurso = null;

Console.WriteLine($"Fecha terminación curso: {fechaTerminacionCurso?.Date}");

bool tieneMascota = true;

Console.WriteLine($"Tengo mascota? : {tieneMascota}");