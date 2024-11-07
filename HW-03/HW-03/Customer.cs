using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public class Customer
{
    public string Name { get; set; }
    public PhoneNumber Phone { get; set; }
    public Address Address { get; set; }

    public Customer(string name, string phoneNumber, Address address)
    {
        Name = name;
        Phone = new PhoneNumber(phoneNumber);
        Address = address;
    }
}