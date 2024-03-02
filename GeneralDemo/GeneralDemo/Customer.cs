using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralDemo

{
    /// <summary>
    /// Represents a customer.
    /// </summary>
    internal class Customer
    {
        // create customer data
        string name;
        string phoneNumber; 
        Food[] Foods;
        Drink[] Drinks;

        // create customer constructor with null values
        public Customer()
        {
            name = null;
            phoneNumber = null;
        }


        // create customer constructor with values
        public Customer(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }


        // ORDER Method
        // create customer order method
        // input Food List
        // input Drink List
        // store the food and drink list in Foods and Drinks variables
        // return string random order number
        // PAY Method
        // create customer pay method
        // input order number
        // return total payment amount
        // return change amount
        // return payment status
        



    

    }
}
