using Csharp_Modelos.Modelos.Clientes;

namespace Csharp_Modelos.Modelos.Produtos;

/// <summary>
/// Classe modelo de criação de pedido
/// </summary>
public class Pedido
{
    
    public Cliente Cliente { get; }
    public DateTime Date { get; }
    public List<ItemDePedido> Itens { get; }

    /// <summary>
    /// Método que soma e retorna o valor total do pedido
    /// </summary>
    public double Total

    {
        get
        {
            return Itens.Sum(itens => itens.SubTotal);
        }
    }

    /// <summary>
    /// Construtor da classe pedido responsavel criar um pedido
    /// e abrir uma lista de itens do pedido
    /// </summary>
    /// <param name="cliente">Parametro do tipo Cliente que recebe o nome do cliente</param>
    public Pedido(Cliente cliente)
    {
        Cliente = cliente;
        Date = DateTime.Now;
        Itens = new List<ItemDePedido>();        
    }

    /// <summary>
    /// Método que exibi os detalhes do pedido.
    /// </summary>
    public void ExibirDetalhesDoPedido()
    {
        Console.WriteLine(
            $"Pedido do cliente -> {Cliente.Nome}           Data do Pedido: {Date}\n");
        Itens.ForEach((itens => Console.WriteLine($"item: {itens.Produto.Nome} | Quantidade: {itens.Quantidade} | Sub Total: {itens.SubTotal} ")));
        Console.WriteLine($"Valor Total do Pedido: R$ {Total}");
    }

    /// <summary>
    /// Método responsavel por adicionar um item ao pedido
    /// </summary>
    /// <param name="item">Item do pedido</param>
    public void AdicionarItem(ItemDePedido item)
    {
        Itens.Add(item);
    }

    public override string ToString()
    {
        return $" Cliente: {Cliente.Nome} | " +
                $"Data do Pedido: {Date} | " +
                $"Total de Itens: {Itens.Count} |" +
                $"Valor Total: {Total}";
    }

}
