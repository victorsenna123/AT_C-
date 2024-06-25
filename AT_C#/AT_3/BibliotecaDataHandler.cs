using System;
using System.Collections.Generic;
using System.IO;

class BibliotecaDataHandler
{
    private const string DataFile = "BibliotecaData.txt";

    public static void SalvarDados(Biblioteca biblioteca)
    {
        using (StreamWriter writer = new StreamWriter(DataFile))
        {
            foreach (var item in biblioteca.ObterItens())
            {
                writer.WriteLine($"{item.GetType().Name};{item.Titulo};{item.Autor};{item.AnoPublicacao};{item.Disponivel}");
            }
        }
    }

    public static void CarregarDados(Biblioteca biblioteca)
    {
        if (!File.Exists(DataFile))
        {
            Console.WriteLine("Arquivo de dados não encontrado.");
            return;
        }

        using (StreamReader reader = new StreamReader(DataFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var fields = line.Split(';');
                string tipo = fields[0];
                string titulo = fields[1];
                string autor = fields[2];
                int anoPublicacao = int.Parse(fields[3]);
                bool disponivel = bool.Parse(fields[4]);

                ItemBiblioteca item;
                if (tipo == nameof(Livro))
                {
                    item = new Livro(titulo, autor, anoPublicacao);
                }
                else
                {
                    item = new Revista(titulo, autor, anoPublicacao);
                }

                item.Disponivel = disponivel;
                biblioteca.AdicionarItem(item);
            }
        }
    }
}
