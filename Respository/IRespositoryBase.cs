using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BTL_Mvc.Respository
{
    public interface IRespositoryBase<T>
    {

        IEnumerable<T> findAll();
        IEnumerable<T> findByCondition(Expression<Func<T, bool>> expression);
        void create(T entity);
        void update(T entity);
        void delete(T entity);
    }
}
