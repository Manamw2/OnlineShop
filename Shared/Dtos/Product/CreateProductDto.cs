using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Dtos.Product
{
    public class CreateProductDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string ImageUrl { get; set; } = string.Empty;
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int CategoryId { get; set; }
    }
}
