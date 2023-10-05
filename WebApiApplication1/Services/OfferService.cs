using WebApiApplication1.Models;

namespace WebApiApplication1.Services
{
    public class OfferService
    {
        private List<Product> Inventory = new List<Product>();

        public OfferService() {
            InitializeInventory();
        }

        private void InitializeInventory()
        {
            Inventory.Add(new Product("P1", 1000, "P1 desc"));
            Inventory.Add(new Product("P2", 200, "P2 desc"));
            Inventory.Add(new Product("P3", 400, "P3 desc"));
            Inventory.Add(new Product("P4", 700, "P4 desc"));
            Inventory.Add(new Product("P5", 600, "P5 desc"));
            Inventory.Add(new Product("P6", 800, "P6 desc"));
        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            List<Offer> offers = new List<Offer>();

            Random rand = new Random();

            for(int i = 1; i <= 4; i++)
            {
                string offerName = "ComboPackage" + i;
                List<Product> randomProducts = GetRandomProducts(3, Inventory, rand);
                offers.Add(new Offer(offerName, randomProducts));
            }

            return offers;
        }

        private List<Product> GetRandomProducts(int count, List<Product> products, Random random)
        {
            List<Product> randomProduct = new List<Product>();

            for(int i = 0; i< count; i++)
            {
                int id = random.Next(products.Count);
                randomProduct.Add(products[id]);
            }

            return randomProduct;
        }

        public void AddProduct(Product newProduct)
        {
            Inventory.Add(newProduct);
        }


    }
}
