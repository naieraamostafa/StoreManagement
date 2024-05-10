
namespace Solid_Principles
{
    public class OnlineStore
    {
        public static void Main(string[] args)
        {
            // Create customers
            Console.WriteLine("Enter regular customer's name:");
            string regularName = Console.ReadLine();
            Console.WriteLine("Enter regular customer's email:");
            string regularEmail = Console.ReadLine();
            ICustomer regularCustomer = new RegularCustomer(regularName, regularEmail);

            Console.WriteLine("Enter VIP customer's name:");
            string vipName = Console.ReadLine();
            Console.WriteLine("Enter VIP customer's email:");
            string vipEmail = Console.ReadLine();
            ICustomer vipCustomer = new VIPCustomer(vipName, vipEmail);

            // Create regular order
            Console.WriteLine("Enter the number of books for Regular customer:");
            int numOfBooksRegular = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of toys for Regular customer:");
            int numOfToysRegular = int.Parse(Console.ReadLine());
            Order regularOrder = Order.CreateOrder(regularCustomer, numOfBooksRegular, numOfToysRegular, new RegularCustomerDiscountStrategy());

            // Create VIP order
            Console.WriteLine("Enter the number of books for VIP customer:");
            int numOfBooksVIP = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of toys for VIP customer:");
            int numOfToysVIP = int.Parse(Console.ReadLine());
            Order vipOrder = Order.CreateOrder(vipCustomer, numOfBooksVIP, numOfToysVIP, new VIPCustomerDiscountStrategy());

            // Print invoices
            Console.WriteLine("Regular Customer's Invoice:");
            regularOrder.PrintInvoice();
            Console.WriteLine();
            Console.WriteLine("VIP Customer's Invoice:");
            vipOrder.PrintInvoice();
        }
    }
}
