using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Medical_Centre.proj.Models
{
    public class MedicalCentreContext : DbContext
    {
        public MedicalCentreContext() : base("Medical Centre")
        {

        }
        public DbSet<PatientDetails> PatientDetails { get; set; }
        

    }
    
}