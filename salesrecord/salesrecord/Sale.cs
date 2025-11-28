public class Venda
{
    public required string vendedor { get; set; }
    public double valor { get; set; }
}

public class Vendas
{
    public required List<Venda>? vendas { get; set; }
}