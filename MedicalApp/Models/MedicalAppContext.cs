using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MedicalApp.Models
{
    public class MedicalAppContext : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Research> Researches { get; set; }
    }
}