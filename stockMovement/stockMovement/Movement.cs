public enum MovementType
{
    Entry,
    Exit,
}
public class StockMovement
{ 

    public Guid Id { get; set; }
    public Product product  { get; set;}
    public MovementType Type { get; set; }

     public StockMovement(Product product, MovementType type)
    {
        this.product = product;
        Type = type;
    }
    
  
}


