1) Create a .Net WebAPI application.
2) Create a class named "Product" with
a) Properties:
i) ProductName : string
ii) Price: decimal
iii) Description: string
b) Constructor that sets the above properties.
3) Create a class named "Offer" with
a) Properties:
i) OfferName: string
ii) Products: a list of Product classes
b) Constructor that sets the above properties.
4) Create a class named "OfferService" with
a) Private property called Inventory which is a list of Products.
b) Private function that creates the following 6 products and adds them to
’Inventory’
ProductName Price Description
P1 1000 P1 desc
c) Constructor to call the above function (to populate ‘Inventory’).
d) Public function named ‘GetAllProducts()’ that returns the products in the
‘Inventory’ property.
e) Public function named ‘GetTodaysOffers()’ that generates and returns four new
Offers with 3 random products each.
For example:
i) “ComboPackage1”, with 3 random products.
ii) “ComboPackage2”, with 3 random products.
iii) “ComboPackage3”, with 3 random products.
iv) “ComboPackage4”, with 3 random products.1) Create an API controller.
2) Inject an "OfferService" into the controller, and assign it to a class variable.
3) Create an async HTTPGET function that uses OfferService.GetTodaysOffers() and
returns the results.
4) Create an async HTTPGET function that uses OfferService.GetAllProducts() and filters
the results to 3 products with the lowest prices, using Linq. Return the 3 products.
5) Create an async HTTPGET function that uses OfferService.GetAllProducts() and filters
the results to the product with the 2nd lowest price.
6) Create an HTTPPost function that adds a given new product to the Products list in the
OfferService.


1) Call the above GET method to find the product with 2nd lowest price. (This should be
Product: ‘P3’.)
2) Call the above POST method to add 1 product.