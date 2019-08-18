﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApplication.Core.Interfaces
{
    public interface IBaseRepository<TEntity, TKey>
        where TEntity : class, IBaseEntity<TKey>
        where TKey : IEquatable<TKey>, IComparable<TKey>
    {
        Task<TEntity> Get(TKey id);
        Task<IEnumerable<TEntity>> GetAll();

        Task Add(TEntity item);
        Task Remove(TEntity entity);
        Task Remove(TKey id);

        Task Put(TKey id, TEntity item);
    }
}