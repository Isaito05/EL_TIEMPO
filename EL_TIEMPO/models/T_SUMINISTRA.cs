using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    [Table("T_SUMINISTRA")]
    public class T_SUMINISTRA
    {
        [Key]   
        public int SUM_ID { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [Display(Name ="Id del proveedor")]
        [ForeignKey("T_PROVEEDOR")]
        public int SUM_PROV_ID { get; set; }

        public T_PROVEEDOR? T_PROVEEDOR { get; set; }

        [Display(Name ="id producto provedor")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [ForeignKey("T_PRO_PROV")]
        public int SUM_PROPROV_ID { get; set; }

        public T_PRO_PROV? T_PRO_PROV { get; set; }


    }
}
