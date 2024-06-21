using Csharp_Comex.Menus.ValidarOpcaoDeMenu;
using Csharp_Modelos.Modelos.Clientes;
using Csharp_Modelos.Modelos.Produtos;

namespace Csharp_Comex.Menus;

public class MenuAdicionarPedido : Menu
{
    public string? ValorDigitado { get; set; }
    public Pedido CadastrarPedido(List<Pedido> pedidos, List<Produto> produtos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoCadastrarPedido();

        Console.Write("\nDigite o nome do Cliente: ");
        string ValorDigitado = Console.ReadLine()!;
        Cliente cliente = new();
        cliente.Nome = ValorDigitado;

        bool opcao = true;
        
        int opcaoEscolhida = 2;
        while (opcao)
        {
            
            while (opcaoEscolhida < 0 || opcaoEscolhida > 1)
            {
                Console.Write("Para visualizar a lista de produtos digite 1 ou 0 para continuar: ");
                ValorDigitado = Console.ReadLine()!;
                opcaoEscolhida = ValidaOpcaoDeMenu.VerificaRetornaOpcaoDigitada(ValorDigitado);
                
            }
            Console.WriteLine();
            switch (opcaoEscolhida)
            {
                case 0:
                    opcao = false;
                    break;
                case 1:
                    ExibirListaDeProdutos(produtos);
                    opcao = false;
                    break;
                default:
                    Console.WriteLine("Opção Invalida!!!");
                    break;
            }
            Console.WriteLine();
        }

        Pedido pedido = new(cliente);

        bool opcaoPedido = true;
        while (opcaoPedido)
        {            
            var existe = false;                
            while (!existe)
            {
                Console.Write("Digite o nome do produto que deseja adicionar a lista de pedido: ");
                ValorDigitado = Console.ReadLine()!;
                existe = VerificaSeProdutoExiste(produtos, ValorDigitado);
                if (!existe) 
                { 
                Console.WriteLine("Produto não encontrado!!");
                }                   
            }            

            var produto = produtos.Find(p => p.Nome == ValorDigitado)!;

            bool numeroInt= false;
            var quantidade = 0;
            while (!numeroInt) 
            {
                Console.Write("\nDigite a quantidade do produto: ");
                ValorDigitado = Console.ReadLine()!;
                quantidade = ValidaOpcaoDeMenu.VerificaSeValorEInteiro(ValorDigitado);                         
                    
                if (quantidade < 1)
                {
                    Console.WriteLine("A quantidade deve ser maior que 0");
                }
                else
                {
                    numeroInt = true;
                }
                
            }
            ItemDePedido item = new(produto, quantidade);
            pedido.AdicionarItem(item);

            opcaoEscolhida = 2;
            while (opcaoEscolhida < 0 || opcaoEscolhida > 1)
            {
                Console.Write("Se deseja cadastrar mais algum item digite 1 senão 0: ");
                ValorDigitado = Console.ReadLine()!;
                opcaoEscolhida = ValidaOpcaoDeMenu.VerificaRetornaOpcaoDigitada(ValorDigitado);
            }            

            if (opcaoEscolhida == 0)
            {
                opcaoPedido = false;
            }
        }


        Console.Write("\nPedido Cadastrado com sucesso\n");
        Console.WriteLine($"\nDetalhes do pedido do cliente: -> {cliente.Nome}\n");
        Console.WriteLine("__________________________________________________________\n");
        pedido.ExibirDetalhesDoPedido();
        Console.WriteLine("\n__________________________________________________________");
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();

        return pedido;

    }

    private void ExibirListaDeProdutos(List<Produto> produtos)
    {
        produtos.ForEach(produtos => Console.WriteLine(produtos.ToString()));
    }

    private bool VerificaSeProdutoExiste(List<Produto> produtos, string nome)
    {
        var existe = produtos.Where(item => item.Nome == nome).FirstOrDefault();
        if (existe == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
}
