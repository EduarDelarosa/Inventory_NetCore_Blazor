using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ProductEntity
    {
        [Key]
        [StringLength(50)]
        public string ProductId { get; set; }

        [StringLength(50)]
        [Required]
        public string ProductName { get; set; }

        [StringLength(150)]
        public string ProductDesctription { get; set; }

        public int Total { get; set; }

        // Relacion con categorias (CategoryEntity)
        public string CategoryId { get; set; }

        public CategoryEntity Category { get; set; }

        // Relacion con almacenamiento (StorageEntity)

        public ICollection<StorageEntity> Storage { get; set; }
    }
}
