

namespace Solid_Principles
{
    internal class Order
    {
        private ICustomer customer;
        private List<IProduct> products = new List<IProduct>();
        private IDiscountStrategy discountStrategy;

        public Order(ICustomer customer)
        {
            this.customer = customer;
        }

        public void AddProduct(IProduct product)
        {
            products.Add(product);
        }

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public double CalculateTotal()
        {
            double total = products.Sum(product => product.GetPrice());
            if (discountStrategy != null)
            {
                total = discountStrategy.ApplyDiscount(total);
            }
            return total;
        }

        public void PrintInvoice()
        {
            Console.WriteLine($"Invoice for {customer.GetName()} ({customer.GetEmail()}):");
            foreach (IProduct product in products)
            {
                Console.WriteLine($"- {product.GetName()}: ${product.GetPrice()}");
            }
            Console.WriteLine($"Total: ${CalculateTotal()}");
        }

        // Factory method to create order
        public static Order CreateOrder(ICustomer customer, int numOfBooks, int numOfToys, IDiscountStrategy discountStrategy)
        {
            Order order = new Order(customer);

            // Add books
            for (int i = 0; i < numOfBooks; i++)
            {
                Console.WriteLine($"Enter book {i + 1} name:");
                string bookName = Console.ReadLine();
                Console.WriteLine($"Enter book {i + 1} price:");
                double bookPrice = Convert.ToDouble(Console.ReadLine());
                order.AddProduct(new Book(bookName, bookPrice));
            }

            // Add toys
            for (int i = 0; i < numOfToys; i++)
            {
                Console.WriteLine($"Enter toy {i + 1} name:");
                string toyName = Console.ReadLine();
                Console.WriteLine($"Enter toy {i + 1} price:");
                double toyPrice = Convert.ToDouble(Console.ReadLine());
                order.AddProduct(new Toy(toyName, toyPrice));
            }

            // Set discount strategy
            order.SetDiscountStrategy(discountStrategy);

            return order;
        }
    }
}
