﻿namespace MotoApp.Repositories;

using MotoApp.Entities;

public class GenericRepository<T> where T : IEntity
{
    protected readonly List<T> _items = [];

    public void Add(T item)
    {
        item.Id = _items.Count + 1;
        _items.Add(item);
    }

    public T GetById(int id)
    {
        return _items.Single(item => item.Id == id);
    }

    public void Save()
    {
        foreach (var item in _items)
        {
            Console.WriteLine(item);
        }
    }
}