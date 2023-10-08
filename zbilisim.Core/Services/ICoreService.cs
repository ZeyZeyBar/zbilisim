using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using zbilisim.Core.Entitiy;

namespace zbilisim.Core.Services
{
    public interface ICoreService<T> where T :CoreEntity
    {
        bool Add(T entity);
        bool Delete(int id);
        bool Update(T entity);
        T GetById(int id);
        T GetRecord(Expression<Func<T, bool>> predicate);
        List<T> GetAll();
        int Save();
    }
}
