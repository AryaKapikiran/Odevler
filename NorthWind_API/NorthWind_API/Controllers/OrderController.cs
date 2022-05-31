using NorthWind_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NorthWind_API.Controllers
{
    public class OrderController : ApiController
    {

        NorthWindEntities db = new NorthWindEntities();

        public IHttpActionResult GetOrders()
        {
            return Ok(db.Orders.ToList());
        }

        public HttpResponseMessage GetOrder(int id)
        {
            Order order = db.Orders.FirstOrDefault(x => x.OrderID == id);

            if (order != null)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, order);
                return response;
            }
            else
            {

                HttpResponseMessage errorResponse = Request.CreateErrorResponse(HttpStatusCode.NotFound, "sipariş bulunamadı");
                return errorResponse;

            }
        }
    }
}
