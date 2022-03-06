using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kitchen_express.Models
{

    [Table("Category")]
    public class Category
    {

        [Display(Name = "Category ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Display(Name = "Name of the Category")]
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

    }

}
