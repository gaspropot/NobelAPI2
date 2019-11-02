using NobelAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NobelAPI
{
    public class AppService
    {
        NobelContext context = new NobelContext();

        public bool AddNobel(string category, int year, string winner)
        {
            context.Nobels.Add(new Nobel
            {
                Category = category,
                Year = year,
                Winner = winner
            });
            context.SaveChanges();

            return true;
        }
    }
}