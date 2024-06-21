using Csharp_Modelos.Modelos.Interfaces;

namespace Csharp_Modelos.Modelos.Produtos;

public class Livro : Produto, IIdentifica
{
    public string Isbn { get; set; }
    public int TotalDePaginas { get; set; }

    public Livro(string nome) : base(nome)
    {
    }

    public string Identificar()
    {
        return $"Nome: {Nome} ISBN: {Isbn}";
    }
}
