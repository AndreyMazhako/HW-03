using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public class Company
{
    public string Name { get; set; }
    public PhoneNumber Phone { get; set; }

    public Company(string name, string phoneNumber)
    {
        Name = name;
        Phone = new PhoneNumber(phoneNumber);
    }
}

