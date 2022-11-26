namespace ShootingRange
{
    public class ShootingRangeServices
    {
        public void EntryMenu(Customer customer, Settings settings)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("s - set number of rounds bought by a customer / c - count rounds you already filled in / p - set new bullet prices");
            Console.WriteLine("or press q to close");
            Console.WriteLine();
            Console.Write("My choice is: ");
            var actionKey = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while (actionKey != 'q')
            {
                switch (actionKey)
                {
                    case 's':
                        SetNumberOfShots(customer);
                        break;
                    case 'c':
                        CountNymberOfShots(customer, settings);
                        break;
                    case 'p':
                        SetPrices(settings);
                        break;
                    default:
                        Console.WriteLine("Invalid operation...");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("s - set number of rounds bought by a customer / c - count rounds you already filled in / p - set new bullet prices");
                Console.WriteLine("or press q to close");
                Console.WriteLine();
                Console.Write("My choice is: ");
                actionKey = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("Program closed");
        }

        public void SetNumberOfShots(Customer customer)
        {            
            Console.WriteLine();
            Console.WriteLine("Choose weapon:");
            Console.WriteLine("1 - Handgun / 2 - Pistol / 3 - Revolver / 4 - Rifle / 5 - Shotgun");
            Console.WriteLine("or press q to exit to previous menu");
            Console.Write("I choose weapon no. : ");
            char actionKey = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while (actionKey != 'q')
            {                
                switch (actionKey)
                {
                    case '1':
                        Console.Write("How many handgun shots you wish to add?  \t");
                        customer.HandgunShots = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '2':
                        Console.Write("How many pistol shots you wish to add?   \t");
                        customer.PistolShots = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '3':
                        Console.Write("How many revolver shots you wish to add? \t");
                        customer.RevolverShots = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '4':
                        Console.Write("How many rifle shots you wish to add?    \t");
                        customer.RifleShots = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '5':
                        Console.Write("How many shotgun shots you wish to add?  \t");
                        customer.ShotgunShots = Int32.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid operation...");
                        Console.WriteLine("Try again.");
                        break;
                }
                Console.Write("I choose weapon no. : ");
                actionKey = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("Going back to menu...");
        }

        public void CountNymberOfShots(Customer customer, Settings settings)
        {
            double totalPrice = Math.Round(customer.HandgunShots * settings.HandgunPrice + customer.PistolShots * settings.PistolPrice + customer.RevolverShots * settings.RevolverPrice + customer.RifleShots * settings.RiflePrice + customer.ShotgunShots * settings.ShotgunPrice, 2);
            double tax = 0.23;
            double priceToPay = Math.Round(totalPrice + totalPrice * tax, 2);

            /*Console.WriteLine("Selected rounds and prices:");
            Console.WriteLine("Weapon    \t\tNo of shots \t\tPrice for 1 shot \t\tPrice for all shots");

            Console.WriteLine($"Handgun  \t\t{customer.HandgunShots} \t\t\t{settings.HandgunPrice} zł\t\t\t\t{customer.HandgunShots * settings.HandgunPrice} zł");
            Console.WriteLine($"Pistol   \t\t{customer.PistolShots} \t\t\t{settings.PistolPrice} zł\t\t\t\t{customer.PistolShots * settings.PistolPrice} zł");
            Console.WriteLine($"Revolver \t\t{customer.RevolverShots} \t\t\t{settings.RevolverPrice} zł\t\t\t\t{customer.RevolverShots * settings.RevolverPrice} zł");
            Console.WriteLine($"Rifle    \t\t{customer.RifleShots} \t\t\t{settings.RiflePrice} zł\t\t\t\t{customer.RifleShots * settings.RiflePrice} zł");
            Console.WriteLine($"Shotgun  \t\t{customer.ShotgunShots} \t\t\t{settings.ShotgunPrice} zł\t\t\t\t{customer.ShotgunShots * settings.ShotgunPrice} zł");
            Console.WriteLine();
            Console.WriteLine($"Total price: \t\t{totalPrice} zł");
            Console.WriteLine($"Vat:         \t\t{tax*100} %");
            Console.WriteLine($"Price to pay:\t\t{priceToPay} zł");*/

            string recipe = "Selected rounds and prices:\n\n" +
            "Weapon    \t\tNo of shots \t\tPrice for 1 shot \t\tPrice for all shots\n" +
            $"Handgun  \t\t{customer.HandgunShots} \t\t\t{settings.HandgunPrice} zł\t\t\t\t{customer.HandgunShots * settings.HandgunPrice} zł\n" +
            $"Pistol   \t\t{customer.PistolShots} \t\t\t{settings.PistolPrice} zł\t\t\t\t{customer.PistolShots * settings.PistolPrice} zł\n" +
            $"Revolver \t\t{customer.RevolverShots} \t\t\t{settings.RevolverPrice} zł\t\t\t\t{customer.RevolverShots * settings.RevolverPrice} zł\n" +
            $"Rifle    \t\t{customer.RifleShots} \t\t\t{settings.RiflePrice} zł\t\t\t\t{customer.RifleShots * settings.RiflePrice} zł\n" +
            $"Shotgun  \t\t{customer.ShotgunShots} \t\t\t{settings.ShotgunPrice} zł\t\t\t\t{customer.ShotgunShots * settings.ShotgunPrice} zł\n\n" +            
            $"Total price: \t\t{totalPrice} zł\n" +
            $"Vat:         \t\t{tax * 100} %\n" +
            $"Price to pay:\t\t{priceToPay} zł" + Environment.NewLine;

            Console.WriteLine(recipe);

            File.WriteAllText(@"..\..\..\Recipes\recipe.txt", recipe);
        }

        public void SetPrices(Settings settings)
        {
            Console.WriteLine();
            Console.WriteLine("!!! Setting new prices for selected weapon rounds !!!");
            Console.WriteLine("Choose weapon:");
            Console.WriteLine("1 - Handgun / 2 - Pistol / 3 - Revolver / 4 - Rifle / 5 - Shotgun");
            Console.WriteLine("or press q to exit to previous menu");

            Console.Write("I choose weapon no. : ");
            char actionKey = Console.ReadKey().KeyChar;
            Console.WriteLine();

            while (actionKey != 'q') ;
            {
                switch (actionKey)
                {
                    case '1':
                        Console.Write("Set new price for handgun round:  \t");
                        settings.HandgunPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '2':
                        Console.Write("Set new price for pistol round:   \t");
                        settings.PistolPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '3':
                        Console.Write("Set new price for revolver round: \t");
                        settings.RevolverPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '4':
                        Console.Write("Set new price for rifle round:    \t");
                        settings.RiflePrice = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    case '5':
                        Console.Write("Set new price for shotgun round:  \t");
                        settings.ShotgunPrice = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Invalid operation...");
                        Console.WriteLine("Try again.");
                        break;
                }
                Console.Write("I choose weapon no. : ");
                actionKey = Console.ReadKey().KeyChar;
                Console.WriteLine();
            }
            Console.WriteLine("Going back to menu...");
        }
    }
}
