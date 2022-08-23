using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_TRAB_PAGO
    {
            [Key]
            [Required(ErrorMessage = "Este campo es obligatorio")]
            public int TRABPAGO_ID { get; set; }
            [Required(ErrorMessage = "Este campo es obligatorio")]
            [Display(Name ="Id del trabajador")]
            public int TRABPAGO_TRAB_ID { get; set; }
            [Display(Name ="Id del pago")]
            public int TRABPAGO_PAGO_ID { get; set; }
        
    }
}
