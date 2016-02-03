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
    public class CurrentShippedOrdersController : ApiController
    {
        private METRICS_REPORTINGEntities db = new METRICS_REPORTINGEntities();

        // GET: api/CurrentShippedOrders
        public IQueryable<CurrentShippedOrders> GetCurrentShippedOrders()
        {
            return db.CurrentShippedOrders;
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CurrentShippedOrderExists(long id)
        {
            return db.CurrentShippedOrders.Count(e => e.ID == id) > 0;
        }
    }
}