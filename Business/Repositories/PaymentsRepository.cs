using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Repositories
{
    public class PaymentsRepository : IRepository<Payment>
    {

        private ICollection<Payment> _payments;

        public PaymentsRepository()
        {
            _payments = new List<Payment>();
        }

        public void Delete(int id)
        {
            var payment = GetByID(id);

            if (payment == null) throw new Exception("Order not found");
                                                                        
            _payments.Remove(payment);
        }

        public ICollection<Payment> GetAll()
        {
            return _payments.ToList();
        }

        public Payment GetByID(int id)
        {
            return _payments.Where(p => p.PaymentId == id).FirstOrDefault();
        }

        public void Insert(Payment entity)
        {
            _payments.Add(entity);
        }

        public void Update(Payment entity)
        {
            var payment = GetByID(entity.PaymentId);

            if (payment == null) throw new Exception("Order not found");

            // Mapping.
            payment.PaymentMethod = entity.PaymentMethod;
        }

        public int LatestId() 
        {
            return _payments.Select(a => a.PaymentId).DefaultIfEmpty().Max() + 1;
        }
    }
}
