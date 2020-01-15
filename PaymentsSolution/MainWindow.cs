using Business.Facades;
using Entities;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PaymentsSolution
{
    public partial class FrmMain : Form
    {
        // Repositories.
        private Facade _context { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            InitForm();
        }

        private void InitForm()
        {
            // Seed.
            _context = Facade.GetInstance();

            cmbSellers.DataSource = _context.SellerFacade.GetAll();
            cmbSellers.DisplayMember = "Name";
            cmbSellers.ValueMember = "SellerId";

            cmbOrders.DisplayMember = "Description";
            cmbOrders.ValueMember = "OrderId";

            // Usage of annoymous array and objects.
            cmbPaymentMethod.DataSource =
                new[]
                {
                new { Value = PaymentMethod.CREDIT, Description = "Credit card" },
                new { Value = PaymentMethod.DEBIT, Description = "Debit card" },
                new { Value = PaymentMethod.PAYPAL, Description = "Paypal" }
                };

            cmbPaymentMethod.DisplayMember = "Description";
            cmbPaymentMethod.ValueMember = "Value";

            UpdateSellerOrders();

            // Handlers
            cmbSellers.SelectedIndexChanged += CmbSellers_SelectedIndexChanged;
        }

        private void CmbSellers_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSellerOrders();
        }

        private void UpdateSellerOrders()
        {
            var sellerId = (int)cmbSellers.SelectedValue;
            // Loads orders of given Seller.
            cmbOrders.SelectedIndex = -1;

            // Retreives orders of given seller that aren't paid.
            cmbOrders.DataSource = _context.OrderFacade.GetAll().Where(o => o.SellerId == sellerId && !o.Paid).ToList();
        }


        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            var orderId = (int)cmbOrders.SelectedValue;

            // Updates the order.
            var order = _context.OrderFacade.GetByID(orderId);

            var payment = new Payment
            {
                PaymentId = _context.PaymentsFacade.LatestId(),
                PaymentMethod = (PaymentMethod)cmbPaymentMethod.SelectedValue,
                Date = DateTime.Now,
                Total = order.Total,
                OrderId = order.OrderId
            };

            // Changes order status.
            order.Paid = true;

            _context.PaymentsFacade.Insert(payment);

            // Loads payments.
            grdPayments.DataSource = _context.PaymentsFacade.GetAll();

            UpdateSellerOrders();
        }
    }
}
