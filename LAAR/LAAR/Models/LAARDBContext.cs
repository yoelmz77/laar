using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LAAR.Models
{
    public class LAARDBContext : DbContext
    {
        public LAARDBContext()
            : base("name=laarconnection")
        {
        }
        public DbSet<Staff> StaffTable { get; set; }
        public DbSet<EducationalLevel> EducationalLevelTable { get; set; }
        public DbSet<Position> PositionTable { get; set; }

    }
}