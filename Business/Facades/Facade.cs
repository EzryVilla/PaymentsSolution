using Business.Repositories;

namespace Business.Facades
{
    public class Facade
    {
        private static Facade instance;

        public OrderRepository OrderFacade { get; }
        public SellerRepository SellerFacade { get; }
        public PaymentsRepository PaymentsFacade { get; }

        private Facade()
        {
            OrderFacade = new OrderRepository();
            SellerFacade = new SellerRepository();
            PaymentsFacade = new PaymentsRepository();
        }

        public static Facade GetInstance() 
        {
            if (instance == null) instance = new Facade();
            return instance;
        }
    }
}
                                                                                           