using Business.Mock;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private ICollection<Order> _orders;
        public OrderRepository()
        {
            _orders = OrdersMock.GetSeed();
        }

        public void Delete(int id)
        {
            var order = GetByID(id);

            if (order == null) throw new Exception("Order not found");

            _orders.Remove(order);
        }

        public ICollection<Order> GetAll()
        {
            return _orders;
        }

        public Order GetByID(int id)
        {
            return _orders.Where(o => o.OrderId == id).FirstOrDefault();
        }

        public void Insert(Order entity)
        {
            _orders.Add(entity);
        }

        public void Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
