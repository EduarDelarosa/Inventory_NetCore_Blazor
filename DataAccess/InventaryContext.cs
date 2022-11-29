using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Product { get; set; }
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<InOuts> InOuts { get; set; }
        public DbSet<StorageEntity> Storage { get; set; }
        public DbSet<WarehouseEntity> Warehouse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=LAPTOP-2QS81BOG\\SQLEXPRESS;Database=InventoryDb;user id=sa; password=santiago009; Trusted_Connection=True; TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo ¨Personal" },
                new CategoryEntity { CategoryId = "HGR", CategoryName = "Hogar" },
                new CategoryEntity { CategoryId = "SLD", CategoryName = "Salud" }
                );

            modelBuilder.Entity<WarehouseEntity>().HasData(
                new WarehouseEntity { WarehouseId= Guid.NewGuid().ToString(), WarehouseName="Bodega Nro 1", WarehouseAddress="Calle falsa 1"},
                new WarehouseEntity { WarehouseId= Guid.NewGuid().ToString(), WarehouseName="Bodega Nro 2", WarehouseAddress="Calle falsa 2"},
                new WarehouseEntity { WarehouseId= Guid.NewGuid().ToString(), WarehouseName="Bodega Nro 3", WarehouseAddress="Calle falsa 3"},
                new WarehouseEntity { WarehouseId= Guid.NewGuid().ToString(), WarehouseName="Bodega Nro 4", WarehouseAddress="Calle falsa 4"}
                );
        }

    }
}
