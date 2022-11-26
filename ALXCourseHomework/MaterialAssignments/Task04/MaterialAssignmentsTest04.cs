namespace ALXCourseHomework.MaterialAssignments.Task04
{
    public class MaterialAssignmentsTest04
    {
        public static void Run()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Material Assignment - Task 4");
            Console.WriteLine("----------------------------");

            Loops loops = new Loops();

            Product product1 = new Product(1, 3.58, 0.05, 10, 2);            
            Product product2 = new Product(2, 9.61, 0.05, 25, 5);            
            Product product3 = new Product(3, 8.52, 0.08, 18, 3);            
            Product product4 = new Product(4, 10.25, 0.08, 36, 6);            
            Product product5 = new Product(5, 6.17, 0.23, 4, 1);            

            Product[] products = new Product[5];
            products[0] = product1;
            products[1] = product2;
            products[2] = product3;
            products[3] = product4;
            products[4] = product5;

            foreach (var product in products)
            {
                product.Brutto();
                Console.WriteLine($"Products Id: {product.Id} price brutto is: {product.PriceBrutto} zł");
                loops.CountStorageValue(product);
                loops.PriceTag(product);
            }

            loops.Dividers();
        }
    }
}
