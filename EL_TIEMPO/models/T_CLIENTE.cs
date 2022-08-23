using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_CLIENTE
    {
        [Key]
        [Display(Name ="Id del cliente :")]
        public int CLI_ID { get; set; }
        [Display(Name ="Identificacion :")]
        public int CLI_RGU_IDENTIFICACION { get; set; }
    }
}
