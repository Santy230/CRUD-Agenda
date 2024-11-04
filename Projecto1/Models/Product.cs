using System.ComponentModel.DataAnnotations;

namespace Projecto1.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage ="Debe Tener un Nombre")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Debe Tener un Precio")]
        public decimal ProductPrice { get; set; }
    }
}
