using NorthWind_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NorthWind_API.Controllers
{
    public class ProductController : ApiController
    {
        NorthWindEntities db = new NorthWindEntities();
        
        //Product Crud

        //Get
        public IHttpActionResult GetProducts()
        {
            
            return Ok(db.Products.ToList());
        }

        public HttpResponseMessage GetProduct(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.ProductID == id);

            if (product != null) 
            {
                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, product);
                return response;

            }

            else
            {
                HttpResponseMessage errorResponse = Request.CreateErrorResponse(HttpStatusCode.NotFound, "product not found");
                return errorResponse;
            }
        }

        public IHttpActionResult PostProduct(Product product)
        {
            if(product != null)
            {
                db.Products.Add(product);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        public HttpResponseMessage PutProduct(Product product)
        {
            Product updatedProduct = db.Products.FirstOrDefault(x => x.ProductID == product.ProductID);

            if (updatedProduct == null)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "ürün bulunamadı");
            }
            else
            {
                updatedProduct.ProductName = product.ProductName;
                updatedProduct.CategoryID = product.CategoryID;
                updatedProduct.SupplierID = product.SupplierID;
                updatedProduct.UnitsInStock = product.UnitsInStock;
                updatedProduct.QuantityPerUnit = product.QuantityPerUnit;
                updatedProduct.UnitPrice = product.UnitPrice;
                return Request.CreateResponse(HttpStatusCode.OK, updatedProduct);
            }
        }

        public IHttpActionResult DeleteProduct(int id)
        {
            try
            {
                db.Products.Remove(db.Products.FirstOrDefault(x=>x.ProductID==id));
                return Ok("ürün silindi");
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

    }
}
