﻿using System.ComponentModel.DataAnnotations;

namespace IMS.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(255)]
        public string Description { get; set; }

        // Navigation property
        public List<Product>? Products { get; set; }
    }
}
