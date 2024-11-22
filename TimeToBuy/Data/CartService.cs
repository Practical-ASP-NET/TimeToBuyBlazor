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
        var cart = Session?.Get<Cart>("Cart") ?? new Cart
        {
            Items =
            [
                new CartItem
                {
                    Quantity = 4,
                    ProductId = 1,
                    ProductName = "Test product",
                    UnitPrice = 100,
                    LinePrice = 100 * 4
                }
            ]
        };
        return cart;
    }

    public async Task Checkout(CartCheckoutInfo cartCheckoutInfo)
    {
        var cart = GetCart();
        
        // process/store order would go here
        // add items from cart, along with captured user details to an order record
        
        Session?.Remove("Cart");
            
    }
}