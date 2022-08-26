using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_BODEGA
    {
        [Key]
        public int BOD_ID { get; set; }
        [Required(ErrorMessage = "Este campo es Obligatorio")]
        public int BOD_STOCK_MINIMO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? BOD_ESTADO { get; set; }
    }
}
