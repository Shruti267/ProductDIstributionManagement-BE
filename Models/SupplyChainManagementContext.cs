using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SupplyChainManagement.Models
{
    public partial class SupplyChainManagementContext : DbContext
    {

        public SupplyChainManagementContext(DbContextOptions<SupplyChainManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderedProduct> OrderedProduct { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Representer> Representer { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<Transport> Transport { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>(entity =>
            {
                entity.Property(e => e.BrandId).HasColumnName("Brand_ID");

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("City_ID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId).HasColumnName("Client_ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gstno)
                    .HasColumnName("GSTNo")
                    .HasMaxLength(50);

                entity.Property(e => e.LandLine).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Mobile).HasColumnType("numeric(10, 0)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("Order_ID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client");
            });

            modelBuilder.Entity<OrderedProduct>(entity =>
            {
                entity.Property(e => e.OrderedProductId).HasColumnName("Ordered_Product_ID");

                entity.Property(e => e.BrandId).HasColumnName("BrandID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.TransportId).HasColumnName("TransportID");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.OrderedProduct)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_Brand");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderedProduct)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_Order");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.OrderedProduct)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_Product");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.OrderedProduct)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_1_Supplier");

                entity.HasOne(d => d.Transport)
                    .WithMany(p => p.OrderedProduct)
                    .HasForeignKey(d => d.TransportId)
                    .HasConstraintName("FK_Table_1_Transport");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId).HasColumnName("Payment_ID");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.PaymentAmount).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentDetails).HasMaxLength(50);

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Order");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Representer>(entity =>
            {
                entity.Property(e => e.RepresenterId).HasColumnName("Representer_ID");

                entity.Property(e => e.RepresenterName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Representer)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Supplier");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.SupplierId).HasColumnName("Supplier_ID");

                entity.Property(e => e.SupplierName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.Property(e => e.TransportId).HasColumnName("Transport_ID");

                entity.Property(e => e.TotalWeight).HasColumnType("numeric(10, 2)");

                entity.Property(e => e.TransporterName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TruckDepartureDate).HasColumnType("date");

                entity.Property(e => e.TruckDriverNumber).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.TruckNumber)
                    .IsRequired()
                    .HasColumnName("Truck_Number")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
