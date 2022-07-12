using CoronaApp.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaApp.Dal
{
    public class CoronaContext:DbContext
    {
         public DbSet<Patient> Patients { get; set; }
        public DbSet<Location> Locations { get; set; }
        public CoronaContext(DbContextOptions options) : base(options)
        {

        }

      
    }
}
