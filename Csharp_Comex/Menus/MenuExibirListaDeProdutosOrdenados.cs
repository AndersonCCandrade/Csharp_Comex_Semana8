using Csharp_Comex.Filtros;
using Csharp_Modelos.Modelos.Produtos;

namespace Csharp_Comex.Menus;

public class MenuExibirListaDeProdutosOrdenados : Menu
{
    public void ListaDeProdutosOrdenadosPorNome(List<Produto> produtos)
    {
        var listaDeProdutos = OrdenacaoDeProdutos.ExibirListaDeProdutosOrdendaPorNome(produtos);
        ExibirListaDeProdutos(listaDeProdutos);
    }

    public void ListaDeProdutosOrdenadosPorPreco(List<Produto> produtos)
    {
        var listaDeProdutos = OrdenacaoDeProdutos.ExibirListaDeProdutosOrdendaPeloPreco(produtos);
        ExibirListaDeProdutos(listaDeProdutos);
    }

    private void ExibirListaDeProdutos(List<Produto> produtos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoListarProduto();
        produtos.ForEach(produto => Console.WriteLine(produto.ToString()));

        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();
    }
}