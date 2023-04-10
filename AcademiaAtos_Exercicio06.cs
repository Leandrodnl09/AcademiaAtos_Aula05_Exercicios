namespace AcademiaAtos_Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo para calcular o fatorial de um número.

            Console.Write("Digite um número para calcular o fatorial: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int fatorial = 1;

            for (int i = 1; i <= num; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {num} é {fatorial}.");
        }
    }
}