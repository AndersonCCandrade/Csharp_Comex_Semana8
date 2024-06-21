namespace Csharp_Modelos.Modelos.Clientes;
public class Endereco
{
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }

    public string ExibirEndereco ()
    {
        return $"{Rua}, {Numero} {Complemento} - {Bairro}\n{Cidade} - {Estado}";
    }

}