using MotoApp.Entities;

namespace MotoApp.Repositories;

public interface IReadRepository<out T> where T : class, IEntity // out T - kowariancja
{
    IEnumerable<T> GetAll();

    T GetById(int id);
}