using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace OrderSystem;
class Program
{
    static void Main(string[] args)
    {
        // Создаем адрес доставки
        Address deliveryAddress = new Address("ул. Ленина", 10, 5, "Москва", "123456");

        // Создаем клиента
        Customer customer = new Customer("Иван Иванов", "+79123456789", deliveryAddress);

        // Создаем компанию-курьера
        Company courierCompany = new Company("СДЭК", "+78001234567");

        // Создаем доставку на дом
        HomeDelivery homeDelivery = new HomeDelivery(deliveryAddress, "Иван Петров", courierCompany);

        // Создаем заказ
        Order order = new Order(homeDelivery, customer);

        // Добавляем товары в заказ
        order.AddProduct(new Product("Телефон", "Смартфон", 30000));
        order.AddProduct(new Product("Наушники", "Беспроводные", 5000));

        // Используем метод расширения для добавления товара
        order.AddProduct(new Product("Футболка", "Черная", 1000));

        // Используем индексатор для доступа к товару
        Console.WriteLine($"Название первого товара: {order[0].Name}");

        // Используем перегруженный оператор +
        order += new Product("Штаны", "Синие", 2000);

        // Используем метод расширения для расчета общей стоимости
        Console.WriteLine($"Общая стоимость заказа: {order.GetTotalCost()}");

        // Выводим информацию о заказе
        order.DisplayOrder();
    }
}
