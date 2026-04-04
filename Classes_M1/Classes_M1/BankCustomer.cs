using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_M1
{
     class BankCustomer
    {
        private string _firstName = "Tim";
        private string _lastName = "Shao";
        public readonly string CustomerId;

        private static int s_nextCustomerId;


        public string FirstName
        {
            get { return _firstName??"N/A"; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName ?? "N/A"; }
            set { _lastName = value; }
        }

        static BankCustomer()
        {
            Random random = new Random();
            s_nextCustomerId = random.Next(10000000, 20000000);
        }

        public BankCustomer()
        {
            this.CustomerId = (s_nextCustomerId++).ToString("D10");
        }
        public BankCustomer(string firstName, string lastName)
        {

            FirstName = firstName;
            LastName = lastName;
            this.CustomerId = (s_nextCustomerId++).ToString("D10");

        }
        

    }
}
