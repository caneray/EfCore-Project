using Entities.Abscract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abscract
{
    // class = referans tip alabilir anlamına gelir.
    // IEntity = IEntity olabilir veya IEntity implement eden bir nesne olabilir.
    // new() = new'lenebilir olmalı 
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null); //filter=null filtre vermene gerek yok yani tüm veriyi getirmeyide isteyebilir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
