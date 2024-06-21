namespace Csharp_Modelos.Modelos.Produtos;

public class ListaDePedido
{
    public static void AdicionarPedidos(List<Pedido> pedidos, Pedido pedido)
    {
       pedidos.Add(pedido);        
    }
}
