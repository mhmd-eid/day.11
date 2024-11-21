﻿using ContactDoctor.Models;
using doctoersWep.Models;
using Microsoft.EntityFrameworkCore;

namespace doctoersWep.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DOC" +
                ";Integrated Security=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor { Id = 1, Name = "Dr. John Smith", Specialization = "Cardiology", Img = "doctor1.jpg"});

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor { Id = 2, Name = "Dr. Sarah Johnson", Specialization = "Pediatrics", Img = "doctor2.jpg" });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor { Id = 3, Name = "Dr. Emily Davis", Specialization = "Dermatology", Img = "doctor4.jpg" });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor { Id = 4, Name = "Dr. Michael Lee", Specialization = "Orthopedics", Img = "doctor3.jpg" });

            modelBuilder.Entity<Doctor>()
                .HasData(new Doctor { Id = 5, Name = "Dr. William Clark", Specialization = "Neurology", Img = "doctor5.jpg" });

            base.OnModelCreating(modelBuilder);
        }
    }
}
