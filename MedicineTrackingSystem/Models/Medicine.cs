using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Models
{
    public class Medicine : BaseEntity
    {
        [Required(ErrorMessage = "Medicine's name is required")]
        [Display(Name = "Name")]
        [StringLength(100,ErrorMessage = "Medicine's name is too long")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Brand's name is required")]
        [Display(Name = "Brand")]
        [StringLength(100, ErrorMessage = "Brand's name is too long")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        [RegularExpression(@"\d+(\.\d{1,2})?", ErrorMessage = "Invalid price")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Amount is required")]
        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Required(ErrorMessage = "It is required")]
        [Display(Name = "ExpiryDate")]
        public string ExpiryDate { get; set; }

    }
}
