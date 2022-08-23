using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_TRABAJADOR
    {
            
            [Key]
            [Required(ErrorMessage = "Este campo es obligatorio")]
            public int TRAB_ID { get; set; }
            [Required(ErrorMessage = "Este campo es obligatorio")]
            [Display(Name ="Identificacion")]    
            public int TRAB_RGU_IDENTIFICACION { get; set; }
        
    }
}
