using System;

class Program
{
    static void Main()
    {
        int[] votos = new int[5];
        int voto;

        do
        {
            Console.WriteLine("\nDigite seu voto:");
            Console.WriteLine("1 - Candidato Joilson");
            Console.WriteLine("2 - Candidato Caramelo");
            Console.WriteLine("3 - Candidato Jandiro");
            Console.WriteLine("9 - Voto Nulo");
            Console.WriteLine("0 - Encerrar votação");
            Console.Write("Opção: ");

            if (!int.TryParse(Console.ReadLine(), out voto))
            {
                Console.WriteLine("Numero invalido ou não existe.");
                continue;
            }

            switch (voto)
            {
                case 1:
                    votos[0]++;
                    break;
                case 2:
                    votos[1]++;
                    break;
                case 3:
                    votos[2]++;
                    break;
                case 9:
                    votos[3]++;
                    break;
                case 0:
                    Console.WriteLine("votação encerrada");
                    break;
            }

        } while (voto != 0);

        Console.WriteLine("\nResultado final:");
        Console.WriteLine($"Candidato Joilson: {votos[0]} votos");
        Console.WriteLine($"Candidato Caramelo: {votos[1]} votos");
        Console.WriteLine($"Candidato Jandiro: {votos[2]} votos");
        Console.WriteLine($"Votos nulos: {votos[3]} votos");
    }
}
