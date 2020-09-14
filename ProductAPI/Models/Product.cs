using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string ProductName { get; set; }

        [Column(TypeName = "varchar(100)")]
        [Required]
        public string Price { get; set; }
    }
}
