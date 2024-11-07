using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public class PickPointDelivery : Delivery
{
    public int PickPointId { get; set; }
    public string PickPointName { get; set; }
    public Company PickPointCompany { get; set; }

    public PickPointDelivery(Address address, int pickPointId, string pickPointName, Company pickPointCompany) : base(address)
    {
        PickPointId = pickPointId;
        PickPointName = pickPointName;
        PickPointCompany = pickPointCompany;
    }

    public override decimal CalculateDeliveryCost()
    {
        // Логика расчета стоимости доставки в пункт выдачи
        return 50;
    }
}