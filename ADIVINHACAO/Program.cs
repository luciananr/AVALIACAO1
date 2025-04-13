using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(1, 1001); // Número aleatório entre 1 e 1000
        int tentativa;
        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Tente adivinhar o número entre 1 e 1000.");

        while (true)
        {
            Console.Write("\nDigite sua tentativa: ");
            if (!int.TryParse(Console.ReadLine(), out tentativa))
            {
                Console.WriteLine("Por favor, insira um número válido.");
                continue;
            }

            int diferenca = Math.Abs(numeroSecreto - tentativa);

            if (tentativa == numeroSecreto)
            {
                Console.WriteLine("Parabéns! Você acertou o número!");
                break;
            }
            else if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else
            {
                Console.WriteLine("O número secreto é menor.");
            }

            if (diferenca > 100)
            {
                Console.WriteLine("Você está muito distante.");
            }
            else if (diferenca > 50)
            {
                Console.WriteLine("Você está distante.");
            }
            else
            {
                Console.WriteLine("Você está perto.");
            }
        }
    }
}
