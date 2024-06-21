using Csharp_Modelos.Modelos.Produtos;

namespace Csharp_Comex.Filtros;

public class OrdenacaoDeProdutos
{
    public static List<Produto> ExibirListaDeProdutosOrdendaPorNome(List<Produto> produtos)
    {
        var listaDeProdutosOrdendaPorNome = produtos.OrderBy(produtos => produtos.Nome).ToList();

        return listaDeProdutosOrdendaPorNome;
    }

    public static List<Produto> ExibirListaDeProdutosOrdendaPeloPreco(List<Produto> produtos)
    {
        var listaDeProdutosOrdendaPeloPreco = produtos.OrderBy(produtos => produtos.Preco).ToList();

        return listaDeProdutosOrdendaPeloPreco;
    }

}
