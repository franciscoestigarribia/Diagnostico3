int posicion=0, final = 0;
string[] nombres = new string[5];
int[] edad=new int[5];
while(final==0)
{
    Console.WriteLine("ingrese su nombre");
    nombres[posicion] = Console.ReadLine();
    Console.WriteLine("ingrese su edad");
    edad[posicion]=int.Parse(Console.ReadLine());
    posicion++;
    if (posicion==5)
    {
        final = 1;
    }
}
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine(nombres[i]);
    Console.WriteLine(edad[i]);
}
Console.ReadKey();