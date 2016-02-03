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
    public class AverageOrderAgesController : ApiController
    {
        private METRICS_REPORTINGEntities db = new METRICS_REPORTINGEntities();

        // GET: api/AverageOrderAges
        public IQueryable<vw_AverageOrderAges> Getvw_AverageOrderAges()
        {
            return db.vw_AverageOrderAges;
        }

        // GET: api/AverageOrderAges/5
        [ResponseType(typeof(vw_AverageOrderAges))]
        public IHttpActionResult Getvw_AverageOrderAges(long id)
        {
            vw_AverageOrderAges vw_AverageOrderAges = db.vw_AverageOrderAges.Find(id);
            if (vw_AverageOrderAges == null)
            {
                return NotFound();
            }

            return Ok(vw_AverageOrderAges);
        }

     
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vw_AverageOrderAgesExists(long id)
        {
            return db.vw_AverageOrderAges.Count(e => e.ID == id) > 0;
        }
    }
}