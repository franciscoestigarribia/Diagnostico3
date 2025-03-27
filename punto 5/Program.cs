int[] numeros1 = new int[5];
int[] numeros2 = new int[5];
int[] resultado = new int[5];
for (int i = 0; i < numeros1.Length; i++)
{
    Console.WriteLine("ingrese un numero");
    numeros1[i] = int.Parse(Console.ReadLine());
    Console.WriteLine("ingrese otro numero");
    numeros2[i]= int.Parse(Console.ReadLine());
    resultado[i] = numeros1[i] + numeros2[i];

}
Console.WriteLine(" " +
    "");
Console.WriteLine("Este es el resultado de la suma de cada numero entre el primero y el segundo");
for (int i = 0;i < numeros1.Length;i++)
{
    Console.WriteLine(resultado[i]);
}
Console.ReadKey();