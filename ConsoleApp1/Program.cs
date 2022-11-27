using ShopApp.Models;

Console.WriteLine("WELCOME TO OUR SHOP!");

var products = new List<Product>();
var shoppingCart = new ShoppingCart();
//shoppingCart.Products.Add(new Product { ProductName = "Mleko", Price = 50.00m });

Console.WriteLine("What would you like to do?");
Console.WriteLine("a - add product to your cart / s - sum up / c - clear cart");
Console.WriteLine("or press q to close");
Console.WriteLine();
Console.Write("My choice is: ");
var actionKey = Console.ReadKey().KeyChar;
Console.WriteLine();

while (actionKey != 'q')
{
    switch (actionKey)
    {
        case 'a':
            Console.WriteLine("Add product:");
            Console.Write("Product name:\t\t\t");
            var product = new Product();
            product.ProductName = Console.ReadLine();
            Console.Write("Type in products price:\t\t");
            product.Price = Decimal.Parse(Console.ReadLine());
            shoppingCart.Products.Add(product);
            break;
        case 's':
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Price to pay: {shoppingCart.GetPrice()} zł");
            Console.WriteLine("--------------------------------------");
            break;
        case 'c':
            shoppingCart.ClearCart();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Your cart is now empty");
            Console.WriteLine("--------------------------------------");
            break;
        default:
            Console.WriteLine("Invalid operation...");
            break;
    }
    Console.WriteLine();    
    Console.WriteLine("a - add product to your cart / s - sum up / c - clear cart");
    Console.WriteLine("or press q to close");
    Console.WriteLine();
    Console.Write("My choice is: ");
    actionKey = Console.ReadKey().KeyChar;
    Console.WriteLine();
}
Console.WriteLine("Program closed");

