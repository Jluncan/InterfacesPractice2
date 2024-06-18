namespace InterfacesPractice2 {
    internal class Program {
        static void Main(string[] args) {

            List<IProduct> products = new List<IProduct>();

            products.Add(new Widget1 { ProductName = "Widget Silver", ProductPrice = 100 });
            products.Add(new Widget1 { ProductName = "Widget Gold", ProductPrice = 75 });
            products.Add(new EchoDot { ProductName = "Echo" , ProductPrice = 50 });
            products.Add(new EchoDot { ProductName = "Echo Xtra", ProductPrice = 99 });


            foreach (var product in products) {
                Console.WriteLine($"Product Name {product.ProductName}, Price: {product.ProductPrice:C}");
            }



        }
    }
}
