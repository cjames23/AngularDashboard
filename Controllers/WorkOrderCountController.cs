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
    public class WorkOrderCountController : ApiController
    {
        private METRICS_REPORTINGEntities db = new METRICS_REPORTINGEntities();

        // GET: api/WorkOrderCount
        public IQueryable<vw_StaleWorkOrderCount> Getvw_StaleWorkOrderCount()
        {
            return db.vw_StaleWorkOrderCount;
        }

        // GET: api/WorkOrderCount/5
        [ResponseType(typeof(vw_StaleWorkOrderCount))]
        public IHttpActionResult Getvw_StaleWorkOrderCount(long id)
        {
            vw_StaleWorkOrderCount vw_StaleWorkOrderCount = db.vw_StaleWorkOrderCount.Find(id);
            if (vw_StaleWorkOrderCount == null)
            {
                return NotFound();
            }

            return Ok(vw_StaleWorkOrderCount);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vw_StaleWorkOrderCountExists(long id)
        {
            return db.vw_StaleWorkOrderCount.Count(e => e.Id == id) > 0;
        }
    }
}