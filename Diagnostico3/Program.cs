int cantidaddecan = 0, posicion=0;
string[] canciones = new string[5];
while(cantidaddecan!=5)
{
    
        Console.WriteLine("ingrese los nombres de 5 canciones porfavor");
    canciones[posicion] = Console.ReadLine();
    posicion++;
    if (posicion == 5)
    {
        cantidaddecan = 5;
    }

}
for (int i = 0; i < canciones.Length;   i++)
{
    Console.WriteLine(canciones[i]);
}
Console.ReadKey();