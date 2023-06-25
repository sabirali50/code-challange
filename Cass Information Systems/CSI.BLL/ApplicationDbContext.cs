
using CIS.SharedKernel.ViewModels;
using CSI.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace CSI.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<ShipmentRate> ShipmentRates { get; set; }

        public DbSet<ShipmentDetail> ShipmentDetails { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}