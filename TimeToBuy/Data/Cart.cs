namespace TimeToBuy.Data;

public record AddItemToCartCommand(int ProductId, decimal Price, string ProductName)
{
}

public class Cart
{
    public List<CartItem> Items { get; set; } = new();

    public decimal TotalPrice => Items.Sum(x => x.LinePrice);
    
    public void Handle(AddItemToCartCommand command)
    {
        var existingItem = Items.SingleOrDefault(x => x.ProductId == command.ProductId);
        if (existingItem != null)
        {
            existingItem.Quantity++;
            existingItem.LinePrice = existingItem.Quantity * existingItem.UnitPrice;
            return;
        }

        Items.Add(new CartItem
        {
            ProductId = command.ProductId,
            UnitPrice = command.Price,
            ProductName = command.ProductName,
            Quantity = 1,
            LinePrice = command.Price
        });
    }
}

public class CartItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal LinePrice { get; set; }
}