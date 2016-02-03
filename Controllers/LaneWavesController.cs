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
    public class LaneWavesController : ApiController
    {
        private METRICS_REPORTINGEntities db = new METRICS_REPORTINGEntities();

        // GET: api/LaneWaves
        public IQueryable<vw_LaneWaves> Getvw_LaneWaves()
        {
            return db.vw_LaneWaves;
        }

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool vw_LaneWavesExists(long id)
        {
            return db.vw_LaneWaves.Count(e => e.ID == id) > 0;
        }
    }
}