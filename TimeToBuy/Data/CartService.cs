using System.Text.Json;

namespace TimeToBuy.Data;

public class CartService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private ISession? _session => _httpContextAccessor?.HttpContext?.Session;

    public CartService(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public void AddToCart(AddItemToCartCommand command)
    {
        var cart = _session?.Get<Cart>("Cart");
        
        if (cart == null)
        {
            cart = new Cart();
            _session?.Set("Cart", cart);
        }
        
        cart.Handle(command);
        _session?.Set("Cart", cart);
    }
}

public record AddItemToCartCommand(int ProductId, double Price)
{
}

public static class SessionExtensions
{
    public static void Set<T>(this ISession session, string key, T value)
    {
        session.SetString(key, JsonSerializer.Serialize(value));
    }

    public static T Get<T>(this ISession session, string key)
    {
        var value = session.GetString(key);
        return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
    }
}