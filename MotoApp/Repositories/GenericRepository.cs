namespace MotoApp.Repositories;

using MotoApp.Entities;

public class GenericRepository<TEntity, TKey>
    where TEntity : class, IEntity, new()
    where TKey : struct
{
    public TKey? Key { get; set; }
    protected readonly List<TEntity> _items = [];

    public TEntity CreatenewItem()
    {
        return new TEntity();
    }

    public void Add(TEntity item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public TEntity GetById(int id)
    {
        return default(TEntity);
        //return _items.Single(item => item.Id == id);
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}