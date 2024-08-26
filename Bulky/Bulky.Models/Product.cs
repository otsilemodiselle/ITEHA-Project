using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }
        
        public string Description { get; set; }

        [Required]
        public string ProductCode { get; set; }

        [Required]
        public string Supplier { get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 5000)]
        public double ListPrice { get; set; }

    }
}
