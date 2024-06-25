using System;

class Program
{
    static void Main()
    {
        ContaCorrente conta = new ContaCorrente(1000, 100); // Saldo inicial de 1000 e limite de 500
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("\nMenu Principal");
            Console.WriteLine("1. Sacar");
            Console.WriteLine("2. Apresentar Saldo");
            Console.WriteLine("3. Depositar");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            try
            {
                switch (opcao)
                {
                    case "1":
                        Console.Write("Digite o valor do saque: ");
                        decimal valorSaque = decimal.Parse(Console.ReadLine());
                        conta.Sacar(valorSaque);
                        Console.WriteLine("Saque realizado com sucesso.");
                        break;
                    case "2":
                        Console.WriteLine($"Saldo atual: {conta.Saldo:C}");
                        break;
                    case "3":
                        Console.Write("Digite o valor do depósito: ");
                        decimal valorDeposito = decimal.Parse(Console.ReadLine());
                        conta.Depositar(valorDeposito);
                        Console.WriteLine("Depósito realizado com sucesso.");
                        break;
                    case "4":
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }
    }
}
