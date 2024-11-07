using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public class HomeDelivery : Delivery
{
    public string Courier { get; set; }
    public Company CourierCompany { get; set; }

    public HomeDelivery(Address address, string courier, Company courierCompany) : base(address)
    {
        Courier = courier;
        CourierCompany = courierCompany;
    }

    public override decimal CalculateDeliveryCost()
    {
        // Логика расчета стоимости доставки на дом
        return 100;
    }
}

