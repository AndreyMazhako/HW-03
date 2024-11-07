using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public static class OrderExtensions
{
    public static void AddProduct(this Order order, Product product)
    {
        order.Items.Add(product);
    }

    // Метод расширения для расчета общей стоимости заказа
    public static decimal GetTotalCost(this Order order)
    {
        return order.GetTotalCost();
    }
}
