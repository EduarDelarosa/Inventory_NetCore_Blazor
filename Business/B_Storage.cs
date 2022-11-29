using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new InventaryContext())
            {
                return db.Storage.ToList();
            }
        }

        public static void CreateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Add(oStorage);
                db.SaveChanges();
            }
        }

        public static void UpdateStorage(StorageEntity oStorage)
        {
            using (var db = new InventaryContext())
            {
                db.Storage.Update(oStorage);
                db.SaveChanges();
            }
        }

        public static List<StorageEntity> StorageProductsByWarehouse(string idWarehouse)
        {
            using (var db = new InventaryContext())
            {
                return db.Storage
                    .Include(w => w.Product)
                    .Include(w => w.Warehouse)
                    .Where(p => p.WarehouseId == idWarehouse)
                    .ToList();
            }
        }

        public static bool Exist(string idStorage)
        {
            using (var db = new InventaryContext())
            {
                var product = db.Storage.ToList().Where(s => s.StorageId == idStorage);

                var x = product.Any();

                return x;
            }
        }
    }
}
