using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    public class T_TRAB_PAGO
    {
            [Key]
            [Required(ErrorMessage = "Este campo es obligatorio")]
            public int TRABPAGO_ID { get; set; }

            [Required(ErrorMessage = "Este campo es obligatorio")]
            [Display(Name ="Id del trabajador")]
            [ForeignKey("T_TRABAJADOR")]
            public int TRABPAGO_TRAB_ID { get; set; }

            public T_TRABAJADOR? T_TRABAJADOR  { get; set; }

            [Display(Name ="Id del pago")]
            [ForeignKey("T_PAGO")]
            public int TRABPAGO_PAGO_ID { get; set; }

             public T_PAGO? T_PAGO  { get; set; }
        
    }
}
