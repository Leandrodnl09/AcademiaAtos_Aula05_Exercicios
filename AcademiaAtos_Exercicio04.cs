namespace AcademiaAtos_Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que leia dois valores pelo teclado, x e y,
            // e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

            Console.WriteLine("Digite o valor da potência (X):");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor a ser elevado (Y)");
            int y = int.Parse(Console.ReadLine());

            int potencia = 1;
            for (int i = 0; i < y; i++)
            {
                potencia *= x;
            }
            Console.WriteLine($"O resultado de {x} elevado a {y} é: {potencia}");
        }
    }
}