using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountBridgeProject
{
    class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


        public Client(string firstName, string lastName, string address)//constructor
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }  

            
        public string GetInfo()
        {
            return FirstName + LastName + Address;

        }
            

    }
}
