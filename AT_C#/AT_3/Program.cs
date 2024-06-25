using System;

class Program
{
    static void Main()
    {
        Biblioteca biblioteca = new Biblioteca();
        
        // Carregar dados do arquivo, se existirem
        BibliotecaDataHandler.CarregarDados(biblioteca);

        // Menu principal do sistema de gerenciamento de biblioteca
        bool sair = false;
        while (!sair)
        {
            Console.WriteLine("\nMenu Principal");
            Console.WriteLine("1. Adicionar Item");
            Console.WriteLine("2. Remover Item");
            Console.WriteLine("3. Exibir Itens");
            Console.WriteLine("4. Realizar Empréstimo");
            Console.WriteLine("5. Devolver Item");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            try
            {
                switch (opcao)
                {
                    case "1":
                        AdicionarItem(biblioteca);
                        break;
                    case "2":
                        RemoverItem(biblioteca);
                        break;
                    case "3":
                        biblioteca.ExibirItens();
                        break;
                    case "4":
                        RealizarEmprestimo(biblioteca);
                        break;
                    case "5":
                        DevolverItem(biblioteca);
                        break;
                    case "6":
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

        // Salvar dados no arquivo ao sair
        BibliotecaDataHandler.SalvarDados(biblioteca);
    }

    static void AdicionarItem(Biblioteca biblioteca)
    {
        Console.WriteLine("Adicionar Item:");
        Console.Write("Digite o tipo (1 para Livro, 2 para Revista): ");
        int tipo = int.Parse(Console.ReadLine());

        Console.Write("Digite o título: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite o autor: ");
        string autor = Console.ReadLine();

        Console.Write("Digite o ano de publicação: ");
        int anoPublicacao = int.Parse(Console.ReadLine());

        ItemBiblioteca item;

        if (tipo == 1)
        {
            item = new Livro(titulo, autor, anoPublicacao);
        }
        else
        {
            item = new Revista(titulo, autor, anoPublicacao);
        }

        biblioteca.AdicionarItem(item);
    }

    static void RemoverItem(Biblioteca biblioteca)
    {
        Console.WriteLine("Remover Item:");
        Console.Write("Digite o título do item a ser removido: ");
        string titulo = Console.ReadLine();

        ItemBiblioteca item = biblioteca.ObterItens().Find(i => i.Titulo == titulo);

        if (item != null)
        {
            biblioteca.RemoverItem(item);
        }
        else
        {
            Console.WriteLine("Item não encontrado.");
        }
    }

    static void RealizarEmprestimo(Biblioteca biblioteca)
    {
        Console.WriteLine("Realizar Empréstimo:");
        Console.Write("Digite o título do item a ser emprestado: ");
        string titulo = Console.ReadLine();

        ItemBiblioteca item = biblioteca.ObterItens().Find(i => i.Titulo == titulo);

        if (item != null)
        {
            biblioteca.RealizarEmprestimo(item);
        }
        else
        {
            Console.WriteLine("Item não encontrado.");
        }
    }

    static void DevolverItem(Biblioteca biblioteca)
    {
        Console.WriteLine("Devolver Item:");
        Console.Write("Digite o título do item a ser devolvido: ");
        string titulo = Console.ReadLine();

        ItemBiblioteca item = biblioteca.ObterItens().Find(i => i.Titulo == titulo);

        if (item != null)
        {
            item.Devolver();
        }
        else
        {
            Console.WriteLine("Item não encontrado.");
        }
    }
}
