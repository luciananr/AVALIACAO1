using System;

class Program
{
    static void Main(string[] args) 
    {
        while (true)
        {
            Console.WriteLine("Digite uma palavra ou frase para verificar se é um palíndromo:");
            string entrada = Console.ReadLine();

            // Verifica se a entrada é nula ou vazia
            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Entrada inválida. Por favor, insira uma palavra ou frase.");
                continue;
            }

            // Remove espaços e converte para letras minúsculas
            string textoFormatado = entrada.Replace(" ", "").ToLower();

            // Verifica se é um palíndromo
            string textoInvertido = new string(textoFormatado.Reverse().ToArray());

            if (textoFormatado == textoInvertido)
            {
                Console.WriteLine("É um palíndromo!");
                break; // Sai do loop quando for um palíndromo
            }
            else
            {
                Console.WriteLine("Não é um palíndromo. Tente novamente.");
            }
        }
    }
}