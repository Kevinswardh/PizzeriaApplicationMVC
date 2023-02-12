using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PizzeriaApplicationMVC.Models
{
    public class PizzaKlass1
    {
        //Tabel Primary Key
        [Key]
        public int Id { get; set; }

        //Profilepicutre
        [Display(Name = "Name")]
        [Required(ErrorMessage = "A name is required")]
        public string PizzaName { get; set; }

        //FullName
        [Display(Name = "Name")]
        [Required(ErrorMessage = "A name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Must be in between 3 and 50 chars")]
        public string PizzaIngre { get; set; }

        //Biography
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Prica is Required")]
        public float Price { get; set; }

      
    }
}
