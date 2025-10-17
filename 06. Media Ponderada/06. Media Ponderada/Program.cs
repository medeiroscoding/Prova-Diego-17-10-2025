using System;

Console.WriteLine("Calcular Media Ponderada");
double n1, p1;
double n2, p2;
double n3, p3;

Console.WriteLine("Digite a nota 1:");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso 1:");
p1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a nota 1:");
n2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso 1:");
p2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a nota 1:");
n3 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o peso 1:");
p3 = Convert.ToDouble(Console.ReadLine());

double media;
media = ((n1 * p1) + (n2 * p2) + (n3 * p3)) / (p1 + p2 + p3);
Console.WriteLine($"Sua media foi: {media}");

if (media >= 7.0) 
{
    Console.WriteLine("Aprovado");
}

else if (media >= 5.0) 
{
    Console.WriteLine("Recuperação");
}
else
{
    Console.WriteLine("Recuperação");
}

