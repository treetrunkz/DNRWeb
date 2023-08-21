using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DNR_Aquatics.Models
{
    public class PugestSoundRegionsContext : DbContext
    {
        public PugestSoundRegionsContext() : base("DNR")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> User { get; set; }
    }
}