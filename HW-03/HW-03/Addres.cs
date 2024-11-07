using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public class Address
{
    public string Street { get; set; }
    public int HouseNumber { get; set; }
    public int ApartmentNumber { get; set; }
    public string City { get; set; }
    public string PostalCode { get; set; }

    public Address(string street, int houseNumber, int apartmentNumber, string city, string postalCode)
    {
        Street = street;
        HouseNumber = houseNumber;
        ApartmentNumber = apartmentNumber;
        City = city;
        PostalCode = postalCode;
    }
}

