using System.Text.Json.Serialization;

namespace Csharp_Modelos.Modelos.Produtos;
public class Produto
{
    public Produto(string nome)
    {
        Nome = nome;
    }

    [JsonPropertyName("title")]
    public string Nome { get; set; }
    [JsonPropertyName("description")]
    public string Descricao { get; set; }
    [JsonPropertyName("price")]
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public override string ToString()
    {
        return  $"Produto: {Nome}\n" +
                $"Descrição: {Descricao}\n" +
                $"Preço: {Preco}\n";
    }
}