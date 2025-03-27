string[] nombres = new string[5];
int[] edad = new int[5];
for (int i = 0; i < nombres.Length; i++)
{
    Console.WriteLine("ingrese su nombre");
    nombres[i] = Console.ReadLine();
    Console.WriteLine("ingrese su edad");
    edad[i]=int.Parse(Console.ReadLine());
}
for (int i = 0;i < edad.Length;i++)
{
    Console.WriteLine(nombres[i]);
    Console.WriteLine(edad[i]);
    Console.WriteLine(" ");
}
Console.ReadKey();