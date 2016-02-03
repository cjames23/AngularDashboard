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
    public class CurrentErrorRateController : ApiController
    {
        private METRICS_REPORTINGEntities db = new METRICS_REPORTINGEntities();

        // GET: api/CurrentErrorRate
        public IQueryable<vw_CurrentErrorRate> Getvw_CurrentErrorRate()
        {
            return db.vw_CurrentErrorRate;
        }

        // GET: api/CurrentErrorRate/5
        [ResponseType(typeof(vw_CurrentErrorRate))]
        public IHttpActionResult Getvw_CurrentErrorRate(int id)
        {
            vw_CurrentErrorRate vw_CurrentErrorRate = db.vw_CurrentErrorRate.Find(id);
            if (vw_CurrentErrorRate == null)
            {
                return NotFound();
            }

            return Ok(vw_CurrentErrorRate);
        }

   
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vw_CurrentErrorRateExists(int id)
        {
            return db.vw_CurrentErrorRate.Count(e => e.ID == id) > 0;
        }
    }
}