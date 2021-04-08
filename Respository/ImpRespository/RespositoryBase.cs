using System;
using System.Collections.Generic;
using System.Linq;
using BTL_Mvc.Models.Entities;

namespace BTL_Mvc.Respository.ImpRespository
{
    public abstract class RespositoryBase<T> : IRespositoryBase<T> where T : class
    {
        protected CosmeticDB_Context repositoryContext { get; set; }

        protected RespositoryBase()
        {
            repositoryContext = new CosmeticDB_Context();
        }

        public void create(T entity)
        {
            throw new NotImplementedException();
        }

        public void delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> findAll()
        {
            return this.repositoryContext.Set<T>();
        }

        public IEnumerable<T> findByCondition(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return this.repositoryContext.Set<T>().Where(expression);
        }

        public void update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}