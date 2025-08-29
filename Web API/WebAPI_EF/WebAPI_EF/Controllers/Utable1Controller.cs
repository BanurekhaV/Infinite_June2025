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
using WebAPI_EF.Models;

namespace WebAPI_EF.Controllers
{
    public class Utable1Controller : ApiController
    {
        private InfiniteDBEntities db = new InfiniteDBEntities();

        // GET: api/Utable1
        public IQueryable<Utable1> GetUtable1()
        {
            return db.Utable1;
        }

        // GET: api/Utable1/5
        [ResponseType(typeof(Utable1))]
        public IHttpActionResult GetUtable1(int id)
        {
            Utable1 utable1 = db.Utable1.Find(id);
            if (utable1 == null)
            {
                return NotFound();
            }

            return Ok(utable1);
        }

        // PUT: api/Utable1/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUtable1(int id, Utable1 utable1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != utable1.uid)
            {
                return BadRequest();
            }

            db.Entry(utable1).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Utable1Exists(id))
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

        // POST: api/Utable1
        [ResponseType(typeof(Utable1))]
        public IHttpActionResult PostUtable1(Utable1 utable1)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Utable1.Add(utable1);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = utable1.uid }, utable1);
        }

        // DELETE: api/Utable1/5
        [ResponseType(typeof(Utable1))]
        public IHttpActionResult DeleteUtable1(int id)
        {
            Utable1 utable1 = db.Utable1.Find(id);
            if (utable1 == null)
            {
                return NotFound();
            }

            db.Utable1.Remove(utable1);
            db.SaveChanges();

            return Ok(utable1);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Utable1Exists(int id)
        {
            return db.Utable1.Count(e => e.uid == id) > 0;
        }
    }
}