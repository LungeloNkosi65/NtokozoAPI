using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Sports_Api.Models;
using Sports_Api.Models.CustomModel;

namespace Sports_Api
{
    public partial class HollywoodBetsRepDbContext : DbContext
    {
        public HollywoodBetsRepDbContext()
        {
        }

        public HollywoodBetsRepDbContext(DbContextOptions<HollywoodBetsRepDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Make>  Makes { get; set; }
        public virtual DbSet<Printer>  Printers { get; set; }
        public virtual DbSet<VPrinter>  VPrinters { get; set; }







        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
