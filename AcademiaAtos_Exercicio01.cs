using System.Net.Http.Headers;
using System.Xml.Schema;

namespace AcademiaAtos_Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo para ler um número n, e em seguida ler pelo teclado calcular a média de idade de n pessoas.

            Console.WriteLine("Digite a quantidade de pessoas: ");
            int n = int.Parse(Console.ReadLine());

            double mediaIdades = 0;
            for (int i = 0; i <= n; i++) 
            {
                Console.WriteLine($"Digite a idade da {i + 1}ª pessoa!";
                int idade = int.Parse(Console.ReadLine());
                mediaIdades += idade;
            }
            Console.WriteLine($"A media das {n} pessoas digitadas são: {mediaIdades}");
        }
    }
}