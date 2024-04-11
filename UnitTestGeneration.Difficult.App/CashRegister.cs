namespace UnitTestGeneration.Difficult.App;
// https://github.com/Mathias007/c-sharp-primary-projects/blob/master/CashRegister/CashRegister/CashRegister.cs
// cy = 16, co = 12
public class CashRegister
{
    struct Product
        {
            public int id; // identyfikator (kod) produktu
            public string name; // nazwa produktu
            public double weight; // waga jednostki (kg)
            public double price; // cena jednostkowa (PLN)
            public double price_per_kg; // cena za 1 kg (PLN)
        }

        struct BillPosition
        {
            public string name; // nazwa produktu
            public string unit; // jednostka ilości
            public double quantity; // ilość produktu
            public double price; // cena do zapłaty
        }

        private static string ChooseUnit()
        {
            Console.WriteLine("Jeśli chcesz zarejestrować zakup na wagę, wybierz W, w przeciwnym razie zarejestrujemy zakup na sztuki.");
            return Console.ReadLine().ToUpper() == "W" ? "kg" : "szt";
        }

        private static double CustomizeQuantity(string unit)
        {
            Console.WriteLine($"Ile {unit} zostało zakupionych?");
            return double.Parse(Console.ReadLine().Replace('.', ','));
        }

        private static double CalculatePrice(double productPrice, double productQuantity)
        {
            return Math.Round(productQuantity * productPrice, 2);
        }

        private static void ShowProductInfo(int productId, string productName, double productWeight, double productPrice, double productPricePerKg)
        {
            Console.WriteLine($"Nazwa produktu: {productName} (Kod {productId})");
            Console.WriteLine($"Waga jednostkowa: {productWeight} kg");
            Console.WriteLine($"Cena jednostkowa: {productPrice} zł");
            Console.WriteLine($"Cena za 1 kg: {productPricePerKg}");
        }

        private static BillPosition AddProductToBill(string productName, double productPrice, double productPricePerKg)
        {
            BillPosition addingPosition;

            addingPosition.name = productName;
            addingPosition.unit = ChooseUnit();
            addingPosition.quantity = CustomizeQuantity(addingPosition.unit);
            addingPosition.price = CalculatePrice((addingPosition.unit == "szt" ? productPrice : productPricePerKg), addingPosition.quantity);

            Console.WriteLine($"Cena za {addingPosition.quantity} {addingPosition.unit} produktu {addingPosition.name} wynosi {addingPosition.price} zł.");

            return addingPosition;
        }

        private static BillPosition HandleProductCustomization(int productId, string productName, double productWeight, double productPrice, double productPricePerKg)
        {
            ShowProductInfo(productId, productName, productWeight, productPrice, productPricePerKg);
            return AddProductToBill(productName, productPrice, productPricePerKg);
        }

        private static BillPosition SelectProduct(Product[] productsArray)
        {
            Console.WriteLine("Wybierz produkt z listy poniżej");

            for (int i = 0; i < productsArray.Length; i++)
            {
                Console.WriteLine($"       {i} - {productsArray[i].name.ToUpper()}");
            }

            Console.Write("     Twój wybór: ");
            var choosenProduct = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wybrałeś {productsArray[choosenProduct].name.ToUpper()}. \n");

            Console.Clear();

            return HandleProductCustomization(
                     productsArray[choosenProduct].id,
                     productsArray[choosenProduct].name,
                     productsArray[choosenProduct].weight,
                     productsArray[choosenProduct].price,
                     productsArray[choosenProduct].price_per_kg
                   );
        }

        private static void PrintBill(List<BillPosition> billList, double bill)
        {
            Console.WriteLine("Drukuję rachunek...");
            foreach (BillPosition billSegment in billList)
            {
                int billPosition = 1;
                Console.WriteLine($"{billPosition}. {billSegment.name} - zakupiono {billSegment.quantity} {billSegment.unit}, cena: {billSegment.price} zł.");
                bill += billSegment.price;
                billPosition++;
            }
            Console.WriteLine($"Rachunek osiągnął wysokość: {bill} zł.");
        }

        private static void HandleCashRegister(Product[] productsArray, List<BillPosition> billList, double billToPay)
        {
            Console.WriteLine("Witamy w naszym warzywniaku!");

            bool isBillOpened = true;

            while (isBillOpened)
            {
                billList.Add(SelectProduct(productsArray));

                Console.WriteLine("Czy chcesz kontynuować? Jeżeli tak, naciśnij Y. Jeżeli nie - wybierz dowolny klawisz, aby wydrukować rachunek.");
                Console.Write("    Twoja decyzja: ");
                if (Console.ReadLine().ToUpper() != "Y")
                {
                    Console.Clear();

                    PrintBill(billList, billToPay);

                    Console.WriteLine("Czy chcesz zarejestrować nowego klienta? Jeżeli tak, naciśnij Y. Jeżeli nie - wybierz dowolny klawisz, aby zakończyć pracę programu.");
                    Console.Write("    Twoja decyzja: ");
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        Console.Clear();
                        billToPay = 0;
                        billList.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Dziękujemy za skorzystanie z programu.");
                        isBillOpened = !isBillOpened;
                    }
                }
                else
                {
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
}