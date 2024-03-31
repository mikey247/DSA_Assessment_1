using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessed_Exercise_1_Solution{
    internal class CustomerQueue{
        private Customer[] customers;
        private int head;
        private int tail;
        private int size;
        private int count;

        public CustomerQueue(int size)
        {
            this.size = size;
            customers = new Customer[size];
            head = 0;
            tail = -1;
            count = 0;
        }

        public int getCount()
        {
            return count;
        }   

        public Customer getCustomer(int index)
        {
            return customers[index];
        }   

        public float calculateTotalAmountOwed(){
            float total = 0;
            for (int i = 0; i < count; i++){
                total += customers[i].AmountOwed;
            }
            return total;
        }

        public Customer getCustomerWithHighestAmountOwed(){
            Customer customer = customers[0];
            for (int i = 1; i < count; i++) {
                if (customers[i].AmountOwed > customer.AmountOwed) {
                    customer = customers[i];
                }
            }
            return customer;
        }   

        public void Enqueue(Customer customer){
            Console.WriteLine("Enque");
            if (count == size){
                Console.WriteLine("CustomerQueue is full");
                return;
            }
            Console.WriteLine("Tail BEfore: " + tail);
            tail = (tail + 1) % size;
            Console.WriteLine("Tail: " + tail);
            Console.WriteLine("Size: " + size); 
            customers[tail] = customer;
            count++;
            Console.WriteLine("Count: " + count);
            Console.WriteLine("\n");
        }

        public Customer Dequeue(){
            Console.WriteLine("Dequeue");
            if (count == 0)
            {
                Console.WriteLine("CustomerQueue is empty");
                return null;
            }
            Customer customer = customers[head];
            Console.WriteLine("Head Before: " + head);
            Console.WriteLine("Size: " + size);
            head = (head + 1) % size;
            count--;

            Console.WriteLine("Head: After" + head);
            Console.WriteLine("Count: " + count);
            return customer;
        }

        public Customer Peek()
        {
            if (count == 0)
            {
                Console.WriteLine("CustomerQueue is empty");
                return null;
            }
            return customers[head];
        }



        public void Display()
        {
            if (count == 0)
            {
                Console.WriteLine("CustomerQueue is empty");
                return;
            }
            int i = head;
            for (int j = 0; j < count; j++)
            {
                Console.WriteLine(customers[i].getInformation());
                i = (i + 1) % size;
            }
        }
    }
}
