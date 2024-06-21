namespace Csharp_Comex.ConsultaApi
{
    public class RequisicaoApi
    {
        HttpClient client = new HttpClient();

        public async Task<string> conexao()
        {
            try
            {
                string resultado = await client.GetStringAsync("https://fakestoreapi.com/products");
                return resultado;
            }
            catch (Exception ex)
            {
                return $"Temos um problema: {ex.Message}";
            }

        }
    }
}
