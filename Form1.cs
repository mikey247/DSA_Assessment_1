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
            customerQueue.Enqueue(new Customer("John", 20, "1 High Street", 70));
            customerQueue.Enqueue(new Customer("Jane", 21, "2 High Street", 20));
            customerQueue.Enqueue(new Customer("Jack", 22, "3 High Street", 30));
            customerQueue.Enqueue(new Customer("Jill", 23, "4 High Street", 40));   
            customerQueue.Enqueue(new Customer("James", 24, "5 High Street", 50));
            getCustomerWithHighestAmountOwed();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e){
            Customer customer = new Customer(nameBox.Text, Convert.ToInt32(ageBox.Text), addressBox.Text, Convert.ToInt32(amountBox.Text));
            customerQueue.Enqueue(customer);
            getCustomerWithHighestAmountOwed();
            nameBox.Text = "";
            ageBox.Text = "";
            addressBox.Text = "";
            amountBox.Text = "";
        }

        private void CustomersBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e) {
            CustomersBox.Items.Clear();

            List<Customer> customers = customerQueue.Display();
            //check length of list
            if(customers !=null && customers.Count > 0){
                foreach (Customer customer in customers){
                    CustomersBox.Items.Add(customer.getInformation());
                }
            }
        }

        private void dequeueButton_Click(object sender, EventArgs e) {
           Customer customer = customerQueue.Dequeue();
            if (customer != null) {
                dequeueTextBox.Text = "Dequeued: " + customer.getInformation();
            }
            getCustomerWithHighestAmountOwed();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void totalDebtButton_Click(object sender, EventArgs e){
           float total = customerQueue.calculateTotalAmountOwed();
            totalDebtBox.Text = "Total amount owed: " + total;
        }

        private void getCustomerWithHighestAmountOwed (){
            Customer customer = customerQueue.getCustomerWithHighestAmountOwed();
            if(customer != null){
                highestDebtorTextBox.Text = "Customer with highest debt: " + customer.getInformation();
            }
            else {
                highestDebtorTextBox.Text = "No customers in queue";
            }
        }   

        private void button1_Click(object sender, EventArgs e) {
          getCustomerWithHighestAmountOwed();
        }
    }
}
