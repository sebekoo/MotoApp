using MotoApp.Entities;

namespace MotoApp.Repositories;

public interface IWriteRepository<in T> where T : class, IEntity // in T - kontrawariancja
{
    void Add(T item);

    void Remove(T item);

    void Save();
}