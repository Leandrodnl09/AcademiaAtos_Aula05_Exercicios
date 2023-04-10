namespace AcademiaAtos_Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
            int maior = 0;
            for (int i = 1; i <= 10;  i++) 
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                int num = int.Parse( Console.ReadLine() );
                if ( num > maior )
                {
                    maior = num;
                }
            }
            Console.WriteLine("O número maior é " + maior);
        }
    }
}