using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NobelAPI.Models
{
    public class NobelContext: DbContext
    {
        public NobelContext() : base("name=Sindesmos")
        {

        }

        public DbSet<Nobel> Nobels { get; set; }
    }
}