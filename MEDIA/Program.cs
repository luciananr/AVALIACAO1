using System; 
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        List<string> nomes = new List<string>();
        List<double> notas = new List<double>();
        string entrada;

        Console.WriteLine("Digite os nomes e notas dos alunos. Para finalizar, digite 'sair'.");

        while (true)
        {
            Console.Write("Nome do aluno: ");
            entrada = Console.ReadLine();

            // Verifica se o nome é nulo ou contém apenas espaços
            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("Nome inválido. Por favor, insira um nome válido.");
                continue;
            }

            if (entrada.ToLower() == "sair") break;

            nomes.Add(entrada);

            Console.Write("Nota do aluno: ");
            if (double.TryParse(Console.ReadLine(), out double nota))
            {
                notas.Add(nota);
            }
            else
            {
                Console.WriteLine("Nota inválida. Tente novamente.");
                nomes.RemoveAt(nomes.Count - 1); // Remove o nome adicionado se a nota for inválida
            }
        }

        if (notas.Count == 0)
        {
            Console.WriteLine("Nenhuma nota foi registrada.");
            return;
        }

        // Opção para calcular a média
        Console.WriteLine("\nDeseja calcular a média da turma? (sim/não)");
        string opcao = Console.ReadLine().ToLower();

        if (opcao == "sim")
        {
            // Calcula a média da turma
            double media = 0;
            foreach (var nota in notas)
            {
                media += nota;
            }
            media /= notas.Count;

            Console.WriteLine($"\nMédia da turma: {media:F2}");
            Console.WriteLine("Alunos com notas acima da média:");

            for (int i = 0; i < notas.Count; i++)
            {
                if (notas[i] > media)
                {
                    Console.WriteLine($"- {nomes[i]}: {notas[i]:F2}");
                }
            }
        }
        else
        {
            Console.WriteLine("Cálculo da média cancelado.");
        }
    }
}