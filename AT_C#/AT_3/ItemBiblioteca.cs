using System;

abstract class ItemBiblioteca
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
    public bool Disponivel { get; set; } = true;

    public ItemBiblioteca(string titulo, string autor, int anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        AnoPublicacao = anoPublicacao;
    }

    public abstract void Emprestar();
    public abstract void Devolver();
    public abstract void ExibirInformacoes();
}
