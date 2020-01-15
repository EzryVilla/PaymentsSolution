using Business.Mock;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Repositories
{
    public class SellerRepository : IRepository<Seller>
    {
        private List<Seller> _repoInstance;

        public SellerRepository()
        {
            _repoInstance = SellersMock.GetSeed();  
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Seller> GetAll()
        {
            return _repoInstance;
        }

        public Seller GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Seller entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Seller entity)
        {
            throw new NotImplementedException();
        }
    }
}
