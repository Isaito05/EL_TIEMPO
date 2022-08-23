using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_TELEFONO
    {
        [Key]
        public int TEL_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Numero de telefono invalido")]
        [Display(Name = "Numero de telefono :")]
        public long TEL_NUMERO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Operador :")]
        public string TEL_OPERADOR { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Identificacion :")]
        public int TEL_RGU_IDENTIFICACION { get; set; } 
       
    }
}
