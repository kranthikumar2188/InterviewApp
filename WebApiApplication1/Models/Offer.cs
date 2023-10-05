namespace WebApiApplication1.Models
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }

        public Offer (string offerName, List<Product> products)
        {
            OfferName = offerName;
            Products = products;
        }
    }
}
