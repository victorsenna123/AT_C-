using System;
using System.Collections.Generic;

class Biblioteca
{
    private List<ItemBiblioteca> itens = new List<ItemBiblioteca>();

    public void AdicionarItem(ItemBiblioteca item)
    {
        itens.Add(item);
        Console.WriteLine($"Item '{item.Titulo}' adicionado à biblioteca.");
    }

    public void RemoverItem(ItemBiblioteca item)
    {
        if (itens.Remove(item))
        {
            Console.WriteLine($"Item '{item.Titulo}' removido da biblioteca.");
        }
        else
        {
            Console.WriteLine($"Item '{item.Titulo}' não encontrado na biblioteca.");
        }
    }

    public void ExibirItens()
    {
        foreach (var item in itens)
        {
            item.ExibirInformacoes();
        }
    }

    public void RealizarEmprestimo(ItemBiblioteca item)
    {
        item.Emprestar();
    }

    public List<ItemBiblioteca> ObterItens()
    {
        return itens;
    }
}
