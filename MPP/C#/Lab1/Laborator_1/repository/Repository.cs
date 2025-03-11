using Lab1.domain;
using Lab1.exceptions;
using System;
using System.Collections.Generic;

namespace Lab1.repository
{
    public interface Repository<ID, E> where E : Entity<ID>
    {
        E FindOne(ID id);
        IEnumerable<E> GetAll();
        void Clear();
        void Save(E entity);
        void Update(E entity);
        void Delete(ID id);
    }
}