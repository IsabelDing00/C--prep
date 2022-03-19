using System;
using System.Collections.Generic;

namespace Assign04
{
    public class IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void Save();
        IEnumerable<T> GetAll();
        T GetById(int id);
    }
}