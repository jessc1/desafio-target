public class StockManager
{
    // A list to store all recorded stock movements
    private List<StockMovement> movements = new List<StockMovement>();

    public Product product1 = new Product { Codigo = 106, Descricao = "Caneta Roxa", Estoque = 200};
    public Product Product2 = new Product { Codigo = 107, Descricao = "Caneta Rosa", Estoque = 5 };

    public void RecordMovement(Product product,MovementType type)
    {
        StockMovement movement = new StockMovement(product, type);
        movements.Add(movement);
        Console.WriteLine($"Movimento Registrado: {movement.Type}");
    }
    public void DisplayMovement()
    {
        Console.WriteLine("\n-- Movimentações de Estoque  --");
        foreach (var movement in movements)
        {
            Console.WriteLine($"Código: {movement.product.Codigo}");
            Console.WriteLine($"Descrição:{movement.product.Descricao}");
            Console.WriteLine($"Estoque: {movement.product.Estoque}");

        }
    }

    public static void Main()
    {
        StockManager manager = new StockManager();
        manager.RecordMovement(manager.product1, MovementType.Entry);
        manager.RecordMovement(manager.product1, MovementType.Exit);
        manager.DisplayMovement();
    }
}

