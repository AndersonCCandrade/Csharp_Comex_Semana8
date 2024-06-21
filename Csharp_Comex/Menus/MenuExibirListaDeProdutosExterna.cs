using Csharp_Comex.ConsultaApi;
using Csharp_Modelos.Modelos.Produtos;
using System.Text.Json;

namespace Csharp_Comex.Menus;

public class MenuExibirListaDeProdutosExterna : Menu
{

    public void ListarProdutosExternos()
    {

        Console.Clear();
        Logo logo = new();
        logo.LogoListaDeProdutoExternos();
        RequisicaoApi requisicao = new RequisicaoApi();
        var resultado = requisicao.conexao().Result;
        var listaDeProdutos = JsonSerializer.Deserialize<List<Produto>>(resultado)!;
        listaDeProdutos.ForEach(produto => Console.WriteLine(produto.ToString() + "\n"));
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();

    }
}
