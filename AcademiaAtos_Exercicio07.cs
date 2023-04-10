namespace AcademiaAtos_Exercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por 
            // um usuário. Apresente o resultado.
            int par = 0, impar = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Digite o {i + 1}º número: ");
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("A qnatidade de numeros pares é de: " + par);
            Console.WriteLine("A qnatidade de numeros impares é de: " + impar);
        }
    }
}