using Microsoft.EntityFrameworkCore;
using StarNote.Models.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarNote.DataAccess
{
    public class Starnoteapicontext : DbContext
    {
        public Starnoteapicontext(DbContextOptions<Starnoteapicontext> options) : base(options)
        {

        }

        public DbSet<GLCase> GLCase  { get; set; }

        public DbSet<GLCostumertype> GLCostumertype  { get; set; }

        public DbSet<GLNote> GLNote  { get; set; }

        public DbSet<GLReminding> GLReminding  { get; set; }

        public DbSet<GLPaymenttype> GLPaymenttype  { get; set; }

        public DbSet<GLProcesstype> GLProcesstype  { get; set; }

        public DbSet<GLProducttype> GLProducttype  { get; set; }

        public DbSet<GLSalesman> GLSalesman  { get; set; }

        public DbSet<GLSalestype> GLSalestype  { get; set; }

        public DbSet<GLStock> GLStock  { get; set; }

        public DbSet<GLUsers> GLUser  { get; set; }

        public DbSet<GLTax> GLTax  { get; set; }

        public DbSet<GLUnit> GLUnit  { get; set; }

        public DbSet<GLLisance> GLLisance  { get; set; }

        public DbSet<GLRoles> GLRoles  { get; set; }

        public DbSet<SPDefinedcompany> SPCompany  { get; set; }

        public DbSet<SPDefinedcostumer> SPCostumer  { get; set; }

        public DbSet<SPCostumerorder> SPCostumerorder  { get; set; }

        public DbSet<SPJoborder> SPJoborder  { get; set; }

        public DbSet<SPFilemanagement> SPFilemanagement  { get; set; }

        public DbSet<ADMenus> ADMenus  { get; set; }

        public DbSet<ADOrderproduct> ADOrderproduct  { get; set; }

        public DbSet<ADProductbase> AdDProductbase  { get; set; }

        public DbSet<ADProductoption> ADProductoption  { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<GLCase>(e => e.Property(o => o.Deletetime).HasColumnType("Datetime").HasConversion<short>());
        //}
    }
}
