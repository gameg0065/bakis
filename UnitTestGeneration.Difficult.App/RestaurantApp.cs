using System.Collections;

namespace UnitTestGeneration.Difficult.App;


//https://github.com/SyedZeenath/CSharp_codes/tree/master/RestaurantManagementApp
// cy = 45, co = 6

public class RestaurantApp
{
    interface IMenuItem
    {
        string ItemName { get; }
        int Price { get; }

        
    }
    
    class SouthIndianItem : IMenuItem
    {
        public bool IsSpicy { get; private set; }
        public string ItemName { get; private set; }
        public int Price { get; private set; }

        public SouthIndianItem(string item, int price, bool isspicy = false)
        {
            this.ItemName = item;
            this.Price = price;
            this.IsSpicy = isspicy;
        }
    }
    
    class Menu : System.Collections.IEnumerable
    {
        private List<IMenuItem> items;

        public Menu()
        {
            this.items = new List<IMenuItem>();
        }
        public void Add(IMenuItem item)
        {
            this.items.Add(item);
        }
        public IEnumerator GetEnumerator()
        {
            foreach(IMenuItem item in this.items )
            {
                yield return item;
            }
        }
    }
    
    class Customer : System.Collections.IEnumerable
    {
        private List<IMenuItem> items;

        public Customer()
        {
            this.items = new List<IMenuItem>();
        }
        public void Add(IMenuItem item)
        {
            this.items.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (IMenuItem item in this.items)
            {
                yield return item;
            }
        }
    }
    
    class Order :IMenuItem
    {
        public string ItemName { get; private set; }
        public int Price { get; }
        public int Quantity { get; private set; }

        public Order(string item, int quantity)
        {
            this.ItemName = item;
            //this.Price = price;
            this.Quantity = quantity;
        }
    }
    
    class CustomerOrders
    {
        public string Name { get; private set; }
        
       
        public Customer Theorder { get; private set; }

        public int Quantity { get; set; }

        public CustomerOrders(string name, Order order, int quantity, params IMenuItem[] orderItems)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Theorder = new Customer();


            //IMenuItem obj1 = new Order("idli", 12);
            //IMenuItem obj2 = new Order("Rajma Rice", 250);
            //this.Theorder.Add(obj1);
            //this.Theorder.Add(obj2);

            foreach (IMenuItem item in orderItems)
            {
                this.Theorder.Add(item);
            }
        }
    }
    
    class NorthIndianItem : IMenuItem
    {
        public string ItemName { get; private set; }
        public int Price { get; private set; }

        public NorthIndianItem(string item, int price)
        {
            this.ItemName = item;
            this.Price = price;
        }
    }
    class Restaurant
    {
        public string Name { get; private set; }
        public Menu TheMenu { get; private set; }

        public Restaurant(string name, params IMenuItem[] menuItems)
        {
            this.Name = name;
            this.TheMenu = new Menu();

            IMenuItem obj1 = new SouthIndianItem("idli", 30);
            IMenuItem obj2 = new NorthIndianItem("Rajma Rice", 150);
            this.TheMenu.Add(obj1);
            this.TheMenu.Add(obj2);

            foreach(IMenuItem item in menuItems)
            {
                this.TheMenu.Add(item);
            }
        }
    }
    
    public static void RunRestaurant()
    {
        Restaurant restaurant = new Restaurant("" +
                                               "Savouries",
            new SouthIndianItem("tea", 20),
            new SouthIndianItem("coffee", 10),
            new NorthIndianItem("friedRice", 50)
        );

        int i = 0;
        Console.WriteLine("Menu of {0} ", restaurant.Name);
        foreach(IMenuItem item in restaurant.TheMenu)
        {
            Console.WriteLine("{0} {1, -20} {2,10} ",++i, item.ItemName, item.Price);
        }
        Console.WriteLine();

        CustomerOrders order = new CustomerOrders("Customer1",
            new Order("milk", 10),
            1
        );
        int j = 0;
        Console.WriteLine("Order of {0} ", order.Name);
        Console.WriteLine();
        foreach (IMenuItem orders in order.Theorder)
        {
            Console.WriteLine("{0} {1, -20} {2,10} ", ++j, orders.ItemName, orders.Price);
        }
        Console.WriteLine();
    }
}