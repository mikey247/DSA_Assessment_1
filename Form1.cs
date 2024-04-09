using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessed_Exercise_1_Solution
{
    public partial class Form1 : Form
    {
        CustomerQueue customerQueue = new CustomerQueue(5);
        public Form1()
        {
            InitializeComponent();
            customerQueue.Enqueue(new Customer("John", 20, "1 High Street", 10));
            customerQueue.Enqueue(new Customer("Jane", 21, "2 High Street", 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e){
            Customer customer = new Customer(nameBox.Text, Convert.ToInt32(ageBox.Text), addressBox.Text, Convert.ToInt32(amountBox.Text));
            customerQueue.Enqueue(customer);
        }

        private void CustomersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e) {
            CustomersBox.Items.Clear();
            int head = customerQueue.getHead();
            for (int i = head; i <= customerQueue.getCount(); i++){
                if(customerQueue.getCustomer(i) != null)
                {
                CustomersBox.Items.Add(i + ": " + customerQueue.getCustomer(i).getInformation());
                }
            }
        }

        private void dequeueButton_Click(object sender, EventArgs e) {
           Customer customer = customerQueue.Dequeue();
            if (customer != null) {
                dequeueTextBox.Text = "Dequeued: " + customer.getInformation();
              }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void totalDebtButton_Click(object sender, EventArgs e){
           float total = customerQueue.calculateTotalAmountOwed();
            totalDebtTextBox.Text = "Total amount owed: " + total;
        }

        private void button1_Click(object sender, EventArgs e) {
            Customer customer = customerQueue.getCustomerWithHighestAmountOwed();
            highestDebtorTextBox.Text = "Customer with highest debt: " + customer.getInformation();
        }
    }
}
