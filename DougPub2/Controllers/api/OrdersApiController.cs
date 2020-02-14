using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using DougPub2.Models;

namespace DougPub2.Controllers
{
    public class OrdersApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public OrdersApiController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/OrdersApi
        public IEnumerable<Order> Get()
        {
            return db.Orders.ToList();
        }

        // GET: api/OrdersApi/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult Get(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // PUT: api/OrdersApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.OrderId)
            {
                return BadRequest();
            }

            db.Entry(order).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/OrdersApi
        [ResponseType(typeof(Order))]
        public IHttpActionResult Post(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Orders.Add(order);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = order.OrderId }, order);
        }

        // DELETE: api/OrdersApi/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult Delete(int id)
        {
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            db.SaveChanges();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItemExists(int id)
        {
            return db.Orders.Count(e => e.OrderId == id) > 0;
        }
    }
}