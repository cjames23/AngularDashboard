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
    public class exceptionsController : ApiController
    {
        private METRICS_REPORTINGEntities db = new METRICS_REPORTINGEntities();

        // GET: api/exceptions
        public IQueryable<vw_exceptions> Getvw_exceptions()
        {
            return db.vw_exceptions;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vw_exceptionsExists(string id)
        {
            return db.vw_exceptions.Count(e => e.usr_id == id) > 0;
        }
    }
}