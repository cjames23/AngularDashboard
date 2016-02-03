using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularWebAPI.Models
{
    public class LanePicks
    {
        public int ID { get; set; }
        public string Lane { get; set; }
        public DateTime OrderDate { get; set; }
        public string OType { get; set; }
        public int Orders { get; set; }
        public int Units { get; set; }
    }
    public class LanePicksDb : ApplicationDbContext
    {
        public DbSet<LanePicks> LanePicks { get; set; }
        
    }
}