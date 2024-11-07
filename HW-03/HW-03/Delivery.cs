using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public abstract class Delivery
{
    public Address Address { get; protected set; }

    public Delivery(Address address)
    {
        Address = address;
    }

    public abstract decimal CalculateDeliveryCost();
}

