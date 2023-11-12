using System;

class Program
{
    static void Main()
    {
        var calculadora = new Calculadora();

        Console.WriteLine("Calculadora");

        while (true)
        {
            Console.WriteLine("Escolha uma operação:");
            Console.WriteLine("1. Somar");
            Console.WriteLine("2. Subtrair");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Sair");

            Console.Write("Digite sua escolha (1-5): ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformOperation(calculadora.Somar, "Somar");
                    break;
                case "2":
                    PerformOperation(calculadora.Subtrair, "Subtrair");
                    break;
                case "3":
                    PerformOperation(calculadora.Multiplicar, "Multiplicar");
                    break;
                case "4":
                    PerformOperation(calculadora.Dividir, "Dividir");
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Escolha inválida. Por gentileza pressiona um número entre 1 e 5.");
                    break;
            }
        }
    }

    static void PerformOperation(Func<int, int, int> operacao, string NomeOperacao)
    {
        Console.Write($"Insira o primeiro número para {NomeOperacao}: ");
        var num1 = int.Parse(Console.ReadLine());

        Console.Write($"Insira o segundo número para {NomeOperacao}: ");
        var num2 = int.Parse(Console.ReadLine());

        try
        {
            var resultado = operacao(num1, num2);
            Console.WriteLine($"{NomeOperacao} resultado: {resultado}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}