using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiApplication1.Models;
using WebApiApplication1.Services;

namespace WebApiApplication1.Controllers
{
    [Route("api/offers")]
    [ApiController]
    public class OfferController : ControllerBase
    {
        private readonly OfferService _offerService;

        public OfferController(OfferService offerService)
        {
            _offerService = offerService;
        }

        [HttpGet("today-offers")]
        public async Task<List<Offer>> GetTodaysOffers()
        {
            return _offerService.GetTodaysOffers();
        }

        [HttpGet("lowest-priced-products")]
        public async Task<List<Product>> GetLowestPricedProducts()
        {
            var products = _offerService.GetAllProducts();
            return products.OrderBy(p => p.Price).Take(3).ToList();
        }

        [HttpGet("second-lowest-priced-product")]
        public async Task<Product> GetSecondLowestPricedProduct()
        {
            var products = _offerService.GetAllProducts();
            return products.OrderBy(p => p.Price).Skip(1).FirstOrDefault();
        }

        [HttpPost("add-product")]
        public async Task<List<Product>> AddProduct([FromBody]Product newProduct)
        {
            _offerService.AddProduct(newProduct);
            return _offerService.GetAllProducts();
        }

    }
}
