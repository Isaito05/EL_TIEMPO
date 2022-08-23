using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_SUMINISTRA
    {
        [Key]   
        public int SUM_ID { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [Display(Name ="Id del proveedor")]
        public int SUM_PROV_ID { get; set; }
        [Display(Name ="id producto provedor")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int SUM_PROPROV_ID { get; set; }

    }
}
