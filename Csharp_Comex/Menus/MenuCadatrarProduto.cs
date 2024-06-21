using Csharp_Modelos.Modelos.Produtos;
using Csharp_Comex.Menus.ValidarOpcaoDeMenu;

namespace Csharp_Comex.Menus;

public class MenuCadatrarProduto : Menu
{
    public Produto CadastrarProduto()
    {
        Console.Clear();
        Logo logo = new();
        logo.LogoCadastrarProduto();
        Console.Write("\nDigite o nome do produto: ");
        string nome = Console.ReadLine()!;
        Console.Write("Digite a descrição: ");
        string descricao = Console.ReadLine()!;
        bool valorDigitado = false;
        double preco = 0;
        while (!valorDigitado)
        {
            Console.Write("Digite o preço: R$ ");
            ValorDigitado = Console.ReadLine()!;
            preco = ValidaOpcaoDeMenu.VerificaSeValorEDouble(ValorDigitado);
            if (preco < 1)
            {
                Console.Write("Valor não pode ser menor ou igual 0\n");
            }
            else 
            {
                valorDigitado = true;
            }            
        }

        int quantidade = 0;
        valorDigitado = false;
        while (!valorDigitado) 
        {
            Console.Write("Digite a quantidade: ");
            ValorDigitado = Console.ReadLine()!;
            quantidade = ValidaOpcaoDeMenu.VerificaSeValorEInteiro(ValorDigitado);
            if (quantidade < 1)
            {
                Console.WriteLine("A quantidade deve ser maior que 0");
            }
            else
            {
                valorDigitado = true;
            }

        }
        Produto produto = new(nome)
        {
            Descricao = descricao,
            Preco = preco,
            Quantidade = quantidade
        };

        Console.WriteLine($"\n\nO produto {nome} foi cadastrado com sucesso!");
        Thread.Sleep(4000);

        return produto;
    }
}

