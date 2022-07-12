using CoronaApp.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoronaApp.Dal
{
    public class CoronaContext:DbContext
    {
         DbSet<Patient> Patients { get; set; }
        DbSet<Location> Lostions { get; set; }
        public CoronaContext(DbContextOptions options) : base(options)
        {

        }

      
    }
}
