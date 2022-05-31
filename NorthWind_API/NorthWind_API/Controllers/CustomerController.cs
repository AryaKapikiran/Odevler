using NorthWind_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NorthWind_API.Controllers
{
    public class CustomerController : ApiController
    {
        NorthWindEntities db = new NorthWindEntities();

        public IHttpActionResult GetCustomers()
        {
            return Ok(db.Customers.ToList());
        }

        public HttpResponseMessage GetCustomer(string id)
        {
            Customer customer = db.Customers.FirstOrDefault(x=>x.CustomerID == id);

            if (customer != null)
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, customer);
                return response;
            }
            else
            {

                HttpResponseMessage errorResponse = Request.CreateErrorResponse(HttpStatusCode.NotFound, "müşteri bulunamadı");
                return errorResponse;

            }
        }
    }
}
