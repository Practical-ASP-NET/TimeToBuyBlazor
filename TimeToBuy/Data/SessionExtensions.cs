using System.Text.Json;

namespace TimeToBuy.Data;

public static class SessionExtensions
{
    public static void Set<T>(this ISession session, string key, T value)
    {
        var serialized = JsonSerializer.Serialize(value);
        session.SetString(key, serialized);
    }

    public static T? Get<T>(this ISession session, string key)
    {
        var value = session.GetString(key);
        return value == null ? default : JsonSerializer.Deserialize<T>(value);
    }
}