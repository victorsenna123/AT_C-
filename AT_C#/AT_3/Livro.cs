using System;

class Livro : ItemBiblioteca, Emprestavel
{
    public Livro(string titulo, string autor, int anoPublicacao)
        : base(titulo, autor, anoPublicacao) { }

    public override void Emprestar()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"Livro '{Titulo}' emprestado com sucesso.");
        }
        else
        {
            Console.WriteLine($"Livro '{Titulo}' não está disponível para empréstimo.");
        }
    }

    public override void Devolver()
    {
        Disponivel = true;
        Console.WriteLine($"Livro '{Titulo}' devolvido com sucesso.");
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Livro] Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Disponível: {Disponivel}");
    }

    public bool VerificarDisponibilidade()
    {
        return Disponivel;
    }

    public DateTime ObterPrazoDeDevolucao()
    {
        return DateTime.Now.AddDays(14); // Prazo de devolução padrão para livros: 14 dias
    }
}
