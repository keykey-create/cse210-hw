using System;

class Program
{
    static void Main(string[] args)
    {
         // Customer 1
        Customer customer1 = new();
        Product customer1Product1 = new();
        Product customer1Product2 = new();
        Product customer1Product3 = new();
        Order order1 = new();
        customer1.SetCustomerName("Mark");
        customer1.SetCustomerAddress("7G Salado Calle", "Limpio", "Western Area", "Paraguay");
        order1.AddCustomer(customer1);
        customer1Product1.SetProductName("Bracelet");
        customer1Product1.SetPrice(50);
        customer1Product1.SetQuantity(2);
        order1.AddProduct(customer1Product1);
        Console.WriteLine("");
        customer1Product2.SetProductName("Earing");
        customer1Product2.SetPrice(75);
        customer1Product2.SetQuantity(4);
        order1.AddProduct(customer1Product2);
        Console.WriteLine("");
        customer1Product3.SetProductName("Ring");
        customer1Product3.SetPrice(86);
        customer1Product3.SetQuantity(1);
        order1.AddProduct(customer1Product3);
        Console.WriteLine("");
        order1.DisplayShippingInfo();


        // Customer 2
        Customer customer2 = new();
        Product customer2Product1 = new();
        Product customer2Product2 = new();
        Product customer2Product3 = new();
        Order order2 = new();
        customer2.SetCustomerName("Keykey");
        customer2.SetCustomerAddress("310 Orange st", "Cheyenne", "Wyoming", "USA");
        order2.AddCustomer(customer2);
        customer2Product1.SetProductName("Purse");
        customer2Product1.SetPrice(125);
        customer2Product1.SetQuantity(1);
        order2.AddProduct(customer2Product1);
        Console.WriteLine("");
        customer2Product2.SetProductName("Necklace");
        customer2Product2.SetPrice(62);
        customer2Product2.SetQuantity(2);
        order2.AddProduct(customer2Product2);
        Console.WriteLine("");
        customer2Product3.SetProductName("Book");
        customer2Product3.SetPrice(25);
        customer2Product3.SetQuantity(3);
        order2.AddProduct(customer2Product3);
        Console.WriteLine("");
        order2.DisplayShippingInfo();

    }
}
