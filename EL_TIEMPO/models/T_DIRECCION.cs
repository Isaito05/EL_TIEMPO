using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    public class T_DIRECCION
    {
        [Key]
        public int DIR_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Tipo De Direccion")]
        public string? DIR_TIPO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Valor De Direccion")]
        public string? DIR_VALOR { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Identificacion del usuario")]
       
        [ForeignKey("T_RGU_USUARIO")]
        public int DIR_RGU_IDENTIFICACION { get; set; }
        public T_RGU_USUARIO? T_RGU_USUARIO { get; set; }
    }
}
