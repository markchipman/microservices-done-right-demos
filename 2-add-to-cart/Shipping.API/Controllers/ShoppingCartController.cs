﻿using Shipping.Data.Context;
using Shipping.Data.Models;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;

namespace Shipping.API.Controllers
{
    public class ShoppingCartController : ApiController
    {
        [HttpPost]
        [Route("api/shopping-cart")]
        public async Task<IHttpActionResult> AddToCart(dynamic data)
        {
            var cartId = (int)data.CartId;
            var productId = (int)data.ProductId;
            var quantity = (int)data.Quantity;

            using (var db = new ShippingContext())
            {
                var shippingDetails = db.ProductsShippingDetails
                    .Where(o => o.ProductId == productId)
                    .Single();

                var cartItem = new ShoppingCartItem()
                {
                    CartId = cartId,
                    RequestId = Request.Headers.GetValues("request-id").Single(),
                    ProductId = productId,
                    Quantity = quantity,
                    ItemShippingCost = shippingDetails.Cost,
                    FreeShippingEligible = shippingDetails.FreeShippingEligible
                };

                db.ShoppingCartItems.Add(cartItem);
                await db.SaveChangesAsync();
            }
            return StatusCode(HttpStatusCode.OK);
        }
    }
}
