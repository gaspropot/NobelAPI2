using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NobelAPI.Models
{
    public class Nobel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string Winner { get; set; }
    }
}