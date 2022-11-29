using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InOuts
    {
        [Key]
        [StringLength(50)]
        public string InOutsId { get; set; }

        [Required]
        public DateTime InOutsDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public bool IsInput { get; set; }


        // Relacion con almacenamiento (StorageEntity)
        public string StorageId { get; set; }

        public StorageEntity Storage { get; set; }
    }
}
