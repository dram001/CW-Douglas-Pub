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
    public class ItemsApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ItemsApiController()
        {
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET: api/ItemsApi
        public IEnumerable<Item> Get()
        {
            return db.Items.ToList();
        }

        // GET: api/ItemsApi/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult Get(int id)
        {
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        // PUT: api/ItemsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Put(int id, Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item.ID)
            {
                return BadRequest();
            }

            db.Entry(item).State = EntityState.Modified;

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

        // POST: api/ItemsApi
        [ResponseType(typeof(Item))]
        public IHttpActionResult Post(Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Items.Add(item);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = item.ID }, item);
        }

        // DELETE: api/ItemsApi/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult Delete(int id)
        {
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            db.Items.Remove(item);
            db.SaveChanges();

            return Ok(item);
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
            return db.Items.Count(e => e.ID == id) > 0;
        }
    }
}