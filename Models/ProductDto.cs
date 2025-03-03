using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
    public class ProductDto
    {
        [Required(ErrorMessage = "El campo Name es obligatorio.")]
        public string Name { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
        public decimal Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que cero.")]
        public int Quantity { get; set; }
    }
}
