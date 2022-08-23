using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PED_PRO
    {
        public int PEDPRO_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Cantidad :")]
        public int PEDPRO_CANTIDAD { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID del Pedido :")]
        public int PEDPRO_PED_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "ID del Producto:")]
        public int PEDPRO_PRO_ID { get; set; }


    }
}
