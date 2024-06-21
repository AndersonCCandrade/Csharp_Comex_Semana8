using Csharp_Comex.Menus.ValidarOpcaoDeMenu;
using Csharp_Modelos.Modelos.Produtos;

namespace Csharp_Comex.Menus;

public class Menu
{
    List<Produto> listaDeProdutos = new List<Produto>();

    List<Pedido> pedidos = new List<Pedido>();
    public string NomeDoSistema { get; } = "CSHARP COMEX";
    public string? ValorDigitado { get; set; }

    public Menu()
    {
        CriarListaDeProdutos();
    }

    public void ExibirOpcoesDoMenu()
    {
         
        Console.Clear();
        Logo logo = new();
        logo.LogoSistema();
        Console.WriteLine("\nDigite 1 para cadastrar Produto");
        Console.WriteLine("Digite 2 para listar todas os produtos");
        Console.WriteLine("Digite 3 para exibir lista de produtos externa");
        Console.WriteLine("Digite 4 para listar produtos ordenados por Nome");
        Console.WriteLine("Digite 5 para listar produtos ordenados por Preço");
        Console.WriteLine("Digite 6 para Criar um pedido");
        Console.WriteLine("Digite 7 para exibir lista de pedidos");
        Console.WriteLine("Digite 0 para sair");

        Console.Write("\nDigite a sua opção: ");
        ValorDigitado = Console.ReadLine()!;

        int opcaoEscolhida = ValidaOpcaoDeMenu.VerificaSeValorEInteiro(ValorDigitado);

        switch (opcaoEscolhida)
        {
            case 1:
                MenuCadatrarProduto menu1 = new();
                listaDeProdutos.Add(menu1.CadastrarProduto());
                break;
            case 2:
                MenuListarProduto menu2 = new();
                menu2.ListarProdutos(listaDeProdutos);
                break;
            case 3:
                MenuExibirListaDeProdutosExterna menu3 = new();
                menu3.ListarProdutosExternos();
                break;
            case 4:
                MenuExibirListaDeProdutosOrdenados menu4 = new();
                menu4.ListaDeProdutosOrdenadosPorNome(listaDeProdutos);
                break;
            case 5:
                MenuExibirListaDeProdutosOrdenados menu5 = new();
                menu5.ListaDeProdutosOrdenadosPorPreco(listaDeProdutos);
                break;
            case 6:
                MenuAdicionarPedido menu6 = new();
                pedidos.Add(menu6.CadastrarPedido(pedidos, listaDeProdutos));
                break;
            case 7:
                MenuListarPedidos menu7 = new();
                menu7.ListaDePedidos(pedidos);
                break;
            case 0:
                Console.WriteLine($"\nObridado por usar o sistema {NomeDoSistema}.\nAté logo!");                
                break;
            default:
                Console.WriteLine("Opção Invalida!!!");
                Thread.Sleep(1000);
                break;
        }
        if (opcaoEscolhida != 0) ExibirOpcoesDoMenu();
        
    }

    private void CriarListaDeProdutos()
    {
        listaDeProdutos.Add(new Produto("Sapato") { Descricao = " Sapato social", Preco = 150.55 });
        listaDeProdutos.Add(new Produto("Camisa") { Descricao = " Camisa social", Preco = 80.25 });
        listaDeProdutos.Add(new Produto("Calça") { Descricao = " Calça social", Preco = 195.32 });
        listaDeProdutos.Add(new Produto("Bleiser") { Descricao = " Bleiser social", Preco = 240.55 });
        listaDeProdutos.Add(new Produto("Meia") { Descricao = " Meia social", Preco = 59.80 });
        listaDeProdutos.Add(new Produto("Cinto") { Descricao = " Cinto social", Preco = 68.00 });
    }
}





