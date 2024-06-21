using Csharp_Modelos.Modelos.Produtos;

namespace Csharp_Comex.Menus;

public class MenuListarProduto : Menu
{

    public void ListarProdutos(List<Produto> listaDeProdutos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoListarProduto();
        foreach (var produto in listaDeProdutos)
        {
            Console.WriteLine(produto.ToString());
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();

    }

    public void ExibirListaDeProdutos(List<Produto> listaDeProdutos)
    {
        listaDeProdutos.ForEach(produto => Console.WriteLine(produto.ToString()));
    }
}
