using Rad2016SampleWepApp.Models.ClubModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace S00148095Week6Lab2.Models.ClubModels.ClubModels
{
    public class ClubDBContext:DbContext
    {
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<ClubEvent> ClubEvents { get; set; }

        public ClubDBContext()
            : base("DefaultConnection")
        {

        }
    }
}