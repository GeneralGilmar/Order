// See https://aka.ms/new-console-template for more information
using Entities;
using Entities.Enum;
using System.Globalization;

Console.WriteLine("Enter cliente data:");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Email: ");
string email= Console.ReadLine();

Console.Write("Birth date (DD/MM/YYYY)" );

DateTime date = DateTime.Parse(Console.ReadLine());

Cliente cliente = new Cliente(name,email,date);

Console.WriteLine("Enter Order data: ");
Console.Write("Status: ");

OrderStatus status =Enum.Parse<OrderStatus>(Console.ReadLine());

Order order = new Order(status,cliente);
Console.Write("How many items to this order?");
int t= int.Parse(Console.ReadLine());

for(int i = 0; i < t; i++)
{
    Console.WriteLine($"Enter #{i+1} item data: ");
    Console.Write("Product name: ");
    string pN= Console.ReadLine();
    Console.Write("Product price: ");
    double pP=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    Console.Write("Quantity: ");
    int quantity= int.Parse(Console.ReadLine());

    Product product = new Product(pN, pP);

    OrderItem orderItem = new OrderItem(quantity,pP,product);
    order.AddItem(orderItem);
}


Console.WriteLine("ORDER SUMMARY: ");
Console.WriteLine(order);



