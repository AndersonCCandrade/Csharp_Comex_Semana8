namespace Csharp_Comex.Menus.ValidarOpcaoDeMenu;

public class ValidaOpcaoDeMenu
{
    public static int VerificaRetornaOpcaoDigitada(string opcao)
    {
        int opcaoEscolhida = 2;
        try
        {
            opcaoEscolhida = int.Parse(opcao);
            if (opcaoEscolhida < 0 || opcaoEscolhida > 1)
            {
                Console.WriteLine("Opção Invalida!!");
            }
            return opcaoEscolhida;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Este campo só recebe os numeros");
            return opcaoEscolhida = 2;
        }
    }

    public static int VerificaSeValorEInteiro(string valorDigitado) 
    {
        int valor = 0;
        try
        {
            valor = int.Parse(valorDigitado);
            return valor;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Este campo só recebe numeros");
            Thread.Sleep(1000);
            return -1;        
        }     

    }

    public static double VerificaSeValorEDouble(string valorDigitado) 
    { 
        double valor = 0;
        try
        {
            valor = double.Parse(valorDigitado!);
            return valor;
        }
        catch (FormatException)
        {
            Console.WriteLine($"Valor digitado não é valido");
            return valor;
        }
        
    }
}
