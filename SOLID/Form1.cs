using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SOLID.Models;
using SOLID.Services;
using SOLID.Repositories;
using System.Drawing.Text;


namespace SOLID
{
    public partial class Form1 : Form
    {
        private decimal total;
        private readonly IOrderRepository orderRepository;
        private readonly EmailService emailService;

        private readonly IInvoicePrinter invoicePrinter;
        public Form1()
        {
            InitializeComponent();

            cmbDiscountType.Items.Add("None");
            cmbDiscountType.Items.Add("Student");
            cmbDiscountType.Items.Add("Senior");
            cmbDiscountType.Items.Add("BlackFriday");

            cmbDiscountType.SelectedIndex = 0;

            orderRepository = new sqlOrderRepository("Server=localhost; Database=Orders;...");

            emailService = new EmailService();
            invoicePrinter = new InvoicePrinter();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            List<OrderItem> items = new List<OrderItem>();

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                if (row.Cells["Price"].Value == null)
                {
                    continue;
                }
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                int quantity = Convert.ToInt32(row.Cells["Qty"].Value);

                OrderItem item = new OrderItem
                {
                    Price = price,
                    Quantity = quantity
                };

                items.Add(item);
            }

            OrderCalculator calculator = new OrderCalculator();

            decimal subTotal = calculator.CalculateSubtotal(items);

            string discountType = cmbDiscountType.SelectedItem?.ToString();

            DiscountFactory factory = new DiscountFactory();

            IDiscountStrategy discount = factory.Create(discountType);

            DiscountService discountService = new DiscountService();

            total = discountService.ApplyDiscount(subTotal, discount);

            lblTotal.Text = total.ToString("C");


        }

        private void btnSaveOrder_Click(object sender, EventArgs e)
        {
            string email = txtCustomerEmail.Text;

            orderRepository.SaveOrder(email, total);

            MessageBox.Show("Order saved successfully!");
        }

        private void btnEmailInvoice_Click(object sender, EventArgs e)
        {
            string email = txtCustomerEmail.Text;

            emailService.SendInvoice(email, total);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            invoicePrinter.Print(txtCustomerEmail.Text, total);
        }
    }
}
