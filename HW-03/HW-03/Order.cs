using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystem;
public class Order
{
    public int Id { get; private set; }
    public Delivery Delivery { get; private set; }
    public Customer Customer { get; private set; }
    public List<Product> Items { get; private set; }
    public OrderStatus Status { get; private set; }

    private static int _nextId = 1; // Идентификатор для заказов

    public Order(Delivery delivery, Customer customer)
    {
        Id = _nextId++;
        Delivery = delivery;
        Customer = customer;
        Items = new List<Product>();
        Status = OrderStatus.Created;
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product item in Items)
        {
            totalCost += item.Price;
        }
        totalCost += Delivery.CalculateDeliveryCost();
        return totalCost;
    }

    public void AddProduct(Product product)
    {
        Items.Add(product);
    }

    public void SetStatus(OrderStatus newStatus)
    {
        Status = newStatus;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Заказ #{Id}");
        Console.WriteLine($"Клиент: {Customer.Name}, {Customer.Phone.Number}");
        Console.WriteLine($"Адрес доставки: {Delivery.Address.Street}, {Delivery.Address.HouseNumber}");
        Console.WriteLine("Товары:");
        foreach (Product item in Items)
        {
            Console.WriteLine($"\t{item.Name}, {item.Price}");
        }
        Console.WriteLine($"Общая стоимость: {GetTotalCost()}");
        Console.WriteLine($"Статус: {Status}");
    }

    // Индексатор для доступа к товарам по индексу
    public Product this[int index]
    {
        get { return Items[index]; }
        set { Items[index] = value; }
    }

    // Перегруженный оператор + для добавления товаров
    public static Order operator +(Order order, Product product)
    {
        order.Items.Add(product);
        return order;
    }
}