using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PRODUCTO
    {
        [Key]
        public int PRO_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PRO_NOMBRE { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string PRO_DESCRIPCION { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public decimal PRO_PRECIO { get; set; }
    }
}
