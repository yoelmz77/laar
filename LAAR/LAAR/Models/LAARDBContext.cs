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
        public DbSet<Note> NoteTable { get; set; }
        public DbSet<Assesment> AssesmentTable { get; set; }
        public DbSet<CompetencyCheck> CompetencyCheckTable { get; set; }

    }
}