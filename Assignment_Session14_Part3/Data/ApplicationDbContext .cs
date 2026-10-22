using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Session14_Part3.Data
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server = localhost\\SAGDA ; Database = Assignment1-Part3; Trusted_Connection = true; TrustServerCertificate = true;");

        public DbSet<Entities.Doctor> Doctors { get; set; }
        public DbSet<Entities.Patient> Patients { get; set; }
        public DbSet<Entities.Appointment> Appointments { get; set; }

    }
}
