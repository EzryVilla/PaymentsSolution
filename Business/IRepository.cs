using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    interface IRepository<TEntity> where TEntity : class
    {
        void Delete(int id);
        TEntity GetByID(int id);
        ICollection<TEntity> GetAll();

        void Insert(TEntity entity);
        void Update(TEntity entity);

    }
}
