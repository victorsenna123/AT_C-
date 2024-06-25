using System;

class Revista : ItemBiblioteca, Emprestavel
{
    public Revista(string titulo, string autor, int anoPublicacao)
        : base(titulo, autor, anoPublicacao) { }

    public override void Emprestar()
    {
        if (Disponivel)
        {
            Disponivel = false;
            Console.WriteLine($"Revista '{Titulo}' emprestada com sucesso.");
        }
        else
        {
            Console.WriteLine($"Revista '{Titulo}' não está disponível para empréstimo.");
        }
    }

    public override void Devolver()
    {
        Disponivel = true;
        Console.WriteLine($"Revista '{Titulo}' devolvida com sucesso.");
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"[Revista] Título: {Titulo}, Autor: {Autor}, Ano: {AnoPublicacao}, Disponível: {Disponivel}");
    }

    public bool VerificarDisponibilidade()
    {
        return Disponivel;
    }

    public DateTime ObterPrazoDeDevolucao()
    {
        return DateTime.Now.AddDays(7); // Prazo de devolução padrão para revistas: 7 dias
    }
}
