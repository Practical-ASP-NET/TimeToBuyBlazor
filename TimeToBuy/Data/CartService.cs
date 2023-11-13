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
        var cart = Session?.Get<Cart>("Cart");
        
        if (cart == null)
        {
            cart = new Cart();
            Session?.Set("Cart", cart);
        }
        
        cart.Handle(command);
        Session?.Set("Cart", cart);
    }
}

public record AddItemToCartCommand(int ProductId, decimal Price)
{
}