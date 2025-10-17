using System;

int inicio, fim;
Console.WriteLine("Digite o numero de inicio");
inicio = int.Parse(Console.ReadLine());
 
Console.WriteLine("Digite o numero final");
fim = int.Parse(Console.ReadLine());

for (int i = inicio; i <= fim; i++)
{
    Console.WriteLine($"Tabuada do {i}:");
    for (int n = 1; n <= 10; n++)
    {
        Console.WriteLine($"{i} x {n} = {i * n}");
    }

}