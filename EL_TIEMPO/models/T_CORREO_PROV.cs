using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    public class T_CORREO_PROV
    {
        [Key]
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public int CORPROV_ID { get; set; }
        [EmailAddress(ErrorMessage = "Este campo debe contener @example.com")]
        [Display(Name = "Correo :")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [ForeignKey("T_PROVEEDOR")]
        public int CORPROV_PROV_ID { get; set; } 
        public T_PROVEEDOR? T_PROVEEDOR { get; set; }
    }
}
