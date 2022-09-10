namespace Cachr.Core;

public interface ICacheStorage
{
    void Set(string key, byte[] obj, TimeSpan? slidingExpiration = null, DateTimeOffset? absoluteExpiration = null);
    byte[]? Get(string key);
    bool TryGet(string key, out byte[] obj);
    void Remove(string key);
    event EventHandler<KeyEvictedEventArgs> KeyEvicted;
}