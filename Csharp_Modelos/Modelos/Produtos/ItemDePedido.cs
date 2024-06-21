namespace Csharp_Modelos.Modelos.Produtos;

/// <summary>
/// Classe modelo de criação de itens de um pedido
/// </summary>
public class ItemDePedido
{
    public Produto Produto { get; }
    public int Quantidade { get; }
    public double PrecoUnitario { get; }
    public double SubTotal { get; }

    /// <summary>
    /// Contrutor da classe itens de pedido que recebe as informações do produto e quantidade,
    /// atribui o valor unitário do produto e calcula o valor total do produto em 
    /// relação a quantidade.
    /// </summary>
    /// <param name="produto">Recebe um produto do tipo Produto</param>
    /// <param name="quantidade">Recebe a quantidade do produto do tipo inteiro</param>
    public ItemDePedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = produto.Preco;
        SubTotal= quantidade * PrecoUnitario;
    }
}
