﻿using System.Linq;
using System.Web.Http;
using Warehouse.Data.Context;

namespace Warehouse.API.Controllers
{
    [RoutePrefix("api/stockitems-status")]
    public class ProductsPricesController : ApiController
    {
        [HttpGet]
        [Route("product/{id}")]
        public dynamic Get(int id)
        {
            using (var db = new WarehouseContext())
            {
                var item = db.StockItems
                    .Where(o => o.ProductId == id)
                    .SingleOrDefault();

                return item;
            }
        }
    }
}
