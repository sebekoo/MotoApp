namespace MotoApp.Repositories;

using MotoApp.Entities;

public class ListRepository<T> : IRepository<T>
    where T : class, IEntity, new()
{
    private readonly List<T> _items = [];

    public IEnumerable<T> GetAll()
    {
        return _items.ToList();  // ToList - tworzy nowy obiekt, dzieki temu operujmy na kopii, a nie na oryginale
    }

    public T GetById(int id)
    {
        return _items.Single(item => item.Id == id);
    }

    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public void Save()
    {
        // save is not required with List
    }
}