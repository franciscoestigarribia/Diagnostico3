string[] canciones = new string[5];
for (int i = 0; i < canciones.Length; i++)
{
    Console.WriteLine("ingrese el nombre de una cancion");
    canciones[i] = Console.ReadLine();
}
for (int i = 0; i < canciones.Length; i++)
{
    Console.WriteLine(canciones[i]);
}
Console.ReadKey();