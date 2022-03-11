using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class studentDbContext: DbContext
    {
        public studentDbContext():base("DefaultConnection")
        {

        }
        public DbSet<student> studentTable { get; set; }
    }


}