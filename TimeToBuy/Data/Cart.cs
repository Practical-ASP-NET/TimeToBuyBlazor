namespace TimeToBuy.Data;

public class Cart
{
    public List<CartItem> Items { get; set; } = new();

    public void Handle(AddItemToCartCommand command)
    {
        var existingItem = Items.SingleOrDefault(x => x.ProductId == command.ProductId);
        if (existingItem != null)
        {
            existingItem.Quantity++;
            return;
        }

        Items.Add(new CartItem
        {
            ProductId = command.ProductId,
            UnitPrice = command.Price,
            ProductName = command.ProductName,
            Quantity = 1
        });
    }
}

public class CartItem
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}