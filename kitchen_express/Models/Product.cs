using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace kitchen_express.Models
{
    public class Product
    {
        [Display(Name = "Product Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [Display(Name = "Product Name")]
        [Required(ErrorMessage = "Product Name cannot be empty")]
        public string ProductName { get; set; }

        [Display(Name = "Product Description")]
        [Required(ErrorMessage = "Product Description cannot be empty")]
        [StringLength(150)]
        public string ProductDescription { get; set; }


        [Display(Name = "Product Price")]
        [Required]
        public decimal ProductPrice { get; set; }


        [Display(Name = "Upload File")]
        public string Image { get; set; }

        [Display(Name = "Available")]
        [Required]
        public bool IsAvailable { get; set; }

        [Display(Name = "Category Type")]
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category CategoryName { get; set; }
    }
}

