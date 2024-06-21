namespace Csharp_Modelos.Modelos.Produtos;

public class ItemDePedido
{
    public Produto Produto { get; }
    public int Quantidade { get; }
    public double PrecoUnitario { get; }
    public double SubTotal { get; }

    public ItemDePedido(Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
        PrecoUnitario = produto.Preco;
        SubTotal= quantidade * PrecoUnitario;
    }
}
