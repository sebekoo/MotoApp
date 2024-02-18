namespace MotoApp.Repositories;

using MotoApp.Entities;

public interface IRepository<T> : IReadRepository<T>, IWriteRepository<T>  // out - kowariancja
    where T : class, IEntity
{
}