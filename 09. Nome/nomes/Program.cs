string[] nomes = { "Marcos", "Odete", "Helena", "Pedro", "Maria" };
string nomeBusca;
int i;
Console.WriteLine("Digite um nome para pesquisar na lista:");
nomeBusca = Console.ReadLine();

int encontrado = 0;
for (i = 0; i < nomes.Length; i++)
{
    if (nomes[i] == (nomeBusca))
    {
        Console.WriteLine($"O nome {nomes[i]} foi encontrado na lista");
        encontrado = 1;
            break;
    }
}
if(encontrado == 0)
{
    Console.WriteLine($"O nome não foi encontrado na lista");
}
