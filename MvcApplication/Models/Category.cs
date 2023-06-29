﻿//
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Invalid nummber")]
        public int DisplayOrder { get; set; }
    }
}