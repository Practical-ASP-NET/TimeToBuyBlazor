namespace TimeToBuy.Data;

public class Cart
{
    public List<CartItem> Items { get; } = new();

    public void Handle(AddItemToCartCommand command)
    {
        Items.Add(new CartItem
        {
            Id = command.ProductId,
            Price = command.Price
        });
    }
}

public class CartItem
{
    public int Id { get; set; }
    public double Price { get; set; }
}