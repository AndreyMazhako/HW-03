using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public class ShopDelivery : Delivery
{
    public int ShopId { get; set; }
    public string ShopName { get; set; }
    public Address ShopAddress { get; set; }

    public ShopDelivery(Address address, int shopId, string shopName, Address shopAddress) : base(address)
    {
        ShopId = shopId;
        ShopName = shopName;
        ShopAddress = shopAddress;
    }

    public override decimal CalculateDeliveryCost()
    {
        // Логика расчета стоимости доставки в магазин
        return 0;
    }
}
