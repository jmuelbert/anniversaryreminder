using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnniversaryReminder.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<jmbdeData.Models.ChipCard> ChipCard { get; set; }
        public virtual DbSet<jmbdeData.Models.ChipCardDoor> ChipCardDoor { get; set; }
        public virtual DbSet<jmbdeData.Models.ChipCardProfile> ChipCardProfile {get; set;}
        public virtual DbSet<jmbdeData.Models.CityName> CityName { get; set; }
        public virtual DbSet<jmbdeData.Models.Company> Company { get; set; }
        public virtual DbSet<jmbdeData.Models.Computer> Computer { get; set; }
        public virtual DbSet<jmbdeData.Models.Department> Department { get; set; }
        public virtual DbSet<jmbdeData.Models.DeviceName> DeviceName { get; set; }
        public DbSet<jmbdeData.Models.DeviceType> DeviceType { get; set; }
        public virtual DbSet<jmbdeData.Models.Document> Document { get; set; }
        public virtual DbSet<jmbdeData.Models.Employee> Employee { get; set; }
        public virtual DbSet<jmbdeData.Models.Fax> Fax { get; set; }
        public virtual DbSet<jmbdeData.Models.Function> Function { get; set; }
        public virtual DbSet<jmbdeData.Models.Inventory> Inventory { get; set; }
        public virtual DbSet<jmbdeData.Models.Manufacturer> Manufacturer { get; set; }
        public virtual DbSet<jmbdeData.Models.Mobile> Mobile { get; set; }
        public virtual DbSet<jmbdeData.Models.Phone> Phone { get; set; }
        public virtual DbSet<jmbdeData.Models.Place> Place { get; set; }
        public virtual DbSet<jmbdeData.Models.Printer> Printer { get; set; }
        public virtual DbSet<jmbdeData.Models.Processor> Processor { get; set; }
        public virtual DbSet<jmbdeData.Models.Software> Software { get; set; }
        public virtual DbSet<jmbdeData.Models.SystemAccount> SystemAccount { get; set; }

        public virtual DbSet<jmbdeData.Models.SystemData> SystemData {get ; set; }
        public virtual DbSet<jmbdeData.Models.JobTitle> JobTitle { get; set; }
        public virtual DbSet<jmbdeData.Models.ZipCode> ZipCode { get; set; }
    }
}
