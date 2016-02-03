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
using AngularWebAPI.Models;

namespace AngularWebAPI.Controllers
{
    public class AgingTotesController : ApiController
    {
        private METRICS_REPORTINGEntities db = new METRICS_REPORTINGEntities();

        // GET: api/AgingTotes
        public IQueryable<AgingTotes> GetAgingTotes()
        {
            return db.AgingTotes;
        }

        // GET: api/AgingTotes/5
        [ResponseType(typeof(AgingTotes))]
        public IHttpActionResult GetAgingTotes(int id)
        {
            AgingTotes agingTotes = db.AgingTotes.Find(id);
            if (agingTotes == null)
            {
                return NotFound();
            }

            return Ok(agingTotes);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AgingTotesExists(int id)
        {
            return db.AgingTotes.Count(e => e.ID == id) > 0;
        }
    }
}