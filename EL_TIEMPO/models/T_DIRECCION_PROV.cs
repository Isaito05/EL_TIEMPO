using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    public class T_DIRECCION_PROV
    {
        [Key]
        public int DIRPROV_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Tipo De Direccion")]
        public string? DIRPROV_TIPO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Valor De Direccion")]
        public string? DIRPROV_VALOR { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Id del Proovedor")]
        [ForeignKey("DIRPROV_PROV_ID")]
        public int DIRPROV_PROV_ID { get; set; }
        public T_PROVEEDOR? T_PROVEEDOR { get; set; }
    }
}
