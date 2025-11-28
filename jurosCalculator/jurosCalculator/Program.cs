public class Program
{
    static void Main()
    {
        Console.Write("Digite o valor  (R$): ");
        double valor = double.Parse(Console.ReadLine());

        Console.Write("Digite a data de vencimento (formato: DD-MM-YYYY): ");
        DateTime dataVencimento = DateTime.Parse(Console.ReadLine());

        double taxaDiaria = 0.025; // 2,5% ao dia

        DateTime dataHoje = DateTime.Today;

        TimeSpan diferenca = dataHoje - dataVencimento;
        int diasAtraso = diferenca.Days;

        // Calcular os juros
        double juros = 0;
        if (diasAtraso > 0)
        {
            juros = valor * taxaDiaria * diasAtraso;
        }

        // Exibir o resultado
        Console.WriteLine($"\nNúmero de dias em atraso: {diasAtraso}");
        Console.WriteLine($"Valor dos juros 2,5% por dia : R$ {juros:F2}");
    }
}
