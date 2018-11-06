using System;
using System.Collections.Generic;

namespace StackOverflow.API.Services
{
    public interface IBaseServices<T>
    {
        IEnumerable<T> GetAll();

        T GetById(int id);

        void Insert(T model);

        void Delete(int id);

        void Update(int id, T model);
    }
}
