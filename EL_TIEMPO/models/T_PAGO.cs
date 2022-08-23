using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PAGO
    {
        public int PAGO_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Fecha De Pago")]
        public DateTime PAGO_FECHA { get; set;  }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Total De Pago")]
        public decimal PAGO_MONTO { get; set; }
    }
}
