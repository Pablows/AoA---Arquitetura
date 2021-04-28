using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;





namespace projeto2.Models
{
    public class contexto: DbContext
    {
        public DbSet<cliente> Cliente { get; set; }
    }
}