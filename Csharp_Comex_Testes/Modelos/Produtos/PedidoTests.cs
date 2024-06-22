using Csharp_Modelos.Modelos.Clientes;
using Csharp_Modelos.Modelos.Produtos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Xunit.Abstractions;

namespace Csharp_Comex_Testes.Modelos.Produtos
{
    public class PedidoTests
    {
        [Fact]
        public void PedidoDeveInicializarComClienteDataEUmaListaDePedido()
        {
            //Arrange
            var cliente = new Cliente() { Nome = "Fulano"};            
            //Act
            Pedido pedido = new(cliente);
            //Assert
            Assert.Equal(cliente.Nome, pedido.Cliente.Nome);
            Assert.True(DateTime.Now.Subtract(pedido.Date).TotalSeconds < 1);
            Assert.Empty(pedido.Itens);
            Assert.Equal(0, pedido.Total);
        }

        [Fact]
        public void ValidaAdicaoDeitensAoPedido()
        {
            //Arrange
            var cliente = new Cliente() { Nome = "Fulano" };
            var produto1 = new Produto("Calça") { Preco = 10.00 };            
            ItemDePedido item1 = new(produto1, 2);            
            var pedido = new Pedido(cliente);
            
            //Act
            pedido.AdicionarItem(item1);           

            //Assert
            Assert.True(pedido.Itens.Count == 1);
            Assert.Contains(item1, pedido.Itens);
            Assert.Equal(produto1.Nome, pedido.Itens[0].Produto.Nome);
        }


        [Fact]
        public void ValidaValorDoSubTotalDosItensDoPedido()
        {
            //Arrange
            var cliente = new Cliente() { Nome = "Fulano" };
            var produto1 = new Produto("Calça") { Preco = 10.00 };            
            ItemDePedido item1 = new(produto1, 2);     
            
            //Act
            var total = item1.SubTotal;
            //Assert
            Assert.Equal(20.00, total);

        }

        [Fact]
        public void ValidaValorTotalDoPedido()
        {
            //Arrange
            var cliente = new Cliente() { Nome = "Fulano" };
            var produto1 = new Produto("Calça") { Preco = 10.00 };
            var produto2 = new Produto("Meia") { Preco = 10.00 };
            var produto3 = new Produto("Sapato") { Preco = 10.00 };
            ItemDePedido item1 = new(produto1, 1);
            ItemDePedido item2 = new(produto2, 1);
            ItemDePedido item3 = new(produto3, 1);
            var pedido = new Pedido(cliente);
            pedido.AdicionarItem(item1);
            pedido.AdicionarItem(item2);
            pedido.AdicionarItem(item3);

            //Act
            var totalGeral = pedido.Total;

            //Assert
            Assert.Equal(30.00, totalGeral);
        }

        [Fact]
        public void ValidaDadosDoPedido()
        {
            //Arrange
            var cliente = new Cliente() { Nome = "Fulano" };
            var produto1 = new Produto("Calça") { Preco = 10.00 };
            var produto2 = new Produto("Meia") { Preco = 10.00 };
            var produto3 = new Produto("Sapato") { Preco = 10.00 };
            ItemDePedido item1 = new(produto1, 1);
            ItemDePedido item2 = new(produto2, 1);
            ItemDePedido item3 = new(produto3, 1);
            var pedido = new Pedido(cliente);
            pedido.AdicionarItem(item1);
            pedido.AdicionarItem(item2);
            pedido.AdicionarItem(item3);
            
            //Act
            string dadosDoPedido = pedido.ToString();
            
            //Assert
            Assert.Equal($" Cliente: Fulano | " +
                $"Data do Pedido: {DateTime.Now} | " +
                $"Total de Itens: 3 |" +
                $"Valor Total: 30", dadosDoPedido);
        }
    }
}