using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    public class T_PED_PRO
    {
        [Key]
        public int PEDPRO_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Cantidad :")]
        public int PEDPRO_CANTIDAD { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID del Pedido :")]
        public int PEDPRO_PED_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID del Producto:")]
        [ForeignKey("T_PROVEEDOR")]
        public int PEDPRO_PRO_ID { get; set; }
        public T_PROVEEDOR? T_PROVEEDOR { get; set; }

    }
}
