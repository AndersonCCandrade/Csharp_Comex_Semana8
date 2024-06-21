using Csharp_Modelos.Modelos.Produtos;

namespace Csharp_Comex.Menus;

public class MenuListarPedidos
{
    public void ListaDePedidos(List<Pedido> pedidos)
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoListarPedido();
        Console.WriteLine("\n");
        if (pedidos.Count == 0)
        {
            Console.WriteLine("\nLista de pedidos vazia"); ;
        }
        else
        {
            var pedidosOrdenados = pedidos.OrderBy(p => p.Cliente.Nome).ToList();
            pedidosOrdenados.ForEach(pedido => Console.WriteLine(pedido.ToString()));
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menur principal");
        Console.ReadKey();
    }
}
