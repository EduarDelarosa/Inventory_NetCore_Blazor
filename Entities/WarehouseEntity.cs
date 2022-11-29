using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class WarehouseEntity
    {
        [Key]
        [StringLength(50)]
        public string WarehouseId { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseName { get; set; }

        [Required]
        [StringLength(50)]
        public string WarehouseAddress { get; set; }

        //Relacion con almacenamiento (StorageEntity)
        public ICollection<StorageEntity> Storage { get; set; }
    }
}
