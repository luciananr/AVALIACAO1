using System;

class Program
{
    static void Main(string[] args)
    {
        // Lista de palavras e seleção aleatória
        string[] palavras = { "LUCIANA", "GATO", "CACHORRO", "PROVA", "CASA" };
        string palavraSecreta = palavras[new Random().Next(palavras.Length)];
        char[] palavraOculta = new string('_', palavraSecreta.Length).ToCharArray();
        int tentativas = 5;

        Console.WriteLine("Bem-vindo ao jogo da forca!");

        while (tentativas > 0 && new string(palavraOculta).Contains('_'))
        {
            Console.WriteLine($"\nPalavra: {new string(palavraOculta)}");
            Console.WriteLine($"Tentativas restantes: {tentativas}");
            Console.Write("Digite uma letra: ");
            char letra = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (palavraSecreta.Contains(letra))
            {
                for (int i = 0; i < palavraSecreta.Length; i++)
                    if (palavraSecreta[i] == letra)
                        palavraOculta[i] = letra;
            }
            else
            {
                tentativas--;
                Console.WriteLine("Letra incorreta!");
            }
        }

        if (new string(palavraOculta).Contains('_'))
            Console.WriteLine($"\nVocê perdeu! A palavra era: {palavraSecreta}");
        else
            Console.WriteLine($"\nParabéns! Você adivinhou a palavra: {palavraSecreta}");
    } 
}