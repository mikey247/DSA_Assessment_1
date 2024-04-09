using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assessed_Exercise_1_Solution
{
    internal class Customer{
        //Implement a class Customer that contains name, age, address
        //and amountOwed in pounds sterling of the student (assume the name and address are string,
        //age is int and amountOwed is a float, remember 5.99f  represents a float value).
        //Customer class should also implement appropriate properties (get / set methods) in the class Customer.  
        private string name;
        private int age;
        private string address;
        private float amountOwed;


        public string Name {
            get { return name; }
            set { name = value; }
        }

        public int Age {
            get { return age; }
            set { age = value; }
        }

        public string Address{
            get { return address; }
            set { address = value; }
        }

        public float AmountOwed {
            get { return amountOwed; }
            set { amountOwed = value; }
        }

        public string getInformation(){
            return "Name: " + name + ", | Age: " + age + ", | Address: " + address + ", | Amount Owed: " + amountOwed;
        }

        public Customer(string name, int age, string address, float amountOwed) {
            this.name = name;
            this.age = age;
            this.address = address;
            this.amountOwed = amountOwed;
        }

        public Customer() {
            this.name = "";
            this.age = 0;
            this.address = "";
            this.amountOwed = 0;
        }
    }
}
