using System.Net.Http.Headers;

namespace AcademiaAtos_Exercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações 
            // aplicadas para aquela turma. Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final
            // (média das notas das avaliações).

            // Numeros de alunos na turma;
            Console.WriteLine("Digite a quantidade de alunos na turma:");
            int n = int.Parse(Console.ReadLine());

            // Qantidade de avaliacões para cada aluno;
            Console.WriteLine("Digite a quantidade de avaliações da turma:");
            int m = int.Parse(Console.ReadLine());

            double media = 0;
            double mediaFinal = 0;
            for (int i = 0; i < n; i++) // Laço de repetição de cada aluno;
            {
                media = 0;
                Console.WriteLine("Digite o nome do aluno:");
                string aluno = Console.ReadLine();
                for (int j = 0; j < m; j++) // Laço de repetição de cada avaliação 
                {
                    Console.Write($"Digite a {j + 1}ª nota do aluno {aluno}: ");
                    double nota = double.Parse(Console.ReadLine());
                    Console.WriteLine();
                    media = media + nota; // soma das notas de cada aluno
                }
                media = media / m;
                Console.WriteLine($"A media do aluno {aluno} é: {media.ToString("F2")}");
                mediaFinal += media; // calculo da media final de cada aluno
            }
            mediaFinal = mediaFinal / n; // calculo da media final de todos os alunos
            Console.WriteLine();
            Console.WriteLine("A média final da turma é: " + mediaFinal.ToString("F2");
        }
    }
}