namespace TimeToBuy.Data;

public class CartService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession? Session => _httpContextAccessor.HttpContext?.Session;

    public CartService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public void AddToCart(AddItemToCartCommand command)
    {
        var cart = Session?.Get<Cart>("Cart") ?? new Cart();
        cart.Handle(command);
        Session?.Set("Cart", cart);
    }

    public Cart? GetCart()
    {
        var cart = Session?.Get<Cart>("Cart");
        return cart;
    }
}

public record AddItemToCartCommand(int ProductId, decimal Price, string ProductName)
{
}