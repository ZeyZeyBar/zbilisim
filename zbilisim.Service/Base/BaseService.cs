using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using zbilisim.Core.Entitiy;
using zbilisim.Core.Services;
using zbilisim.Model.Context;

namespace zbilisim.Service.Base
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        private readonly zbilisimContext _db;
        public BaseService(zbilisimContext db)
        {
            _db = db;
        }
        public bool Add(T entity)
        {
            try
            {
                _db.Set<T>().Add(entity);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _db.Set<T>().Remove(GetById(id));
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<T> GetAll()=>_db.Set<T>().ToList(); 

        public T GetById(int id) => _db.Set<T>().Find(id);

        public T GetRecord(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().FirstOrDefault(predicate);
        }

        public int Save()
        {
           return _db.SaveChanges();
        }

        public bool Update(T entity)
        {
            try
            {
                _db.Set<T>().Update(entity);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
