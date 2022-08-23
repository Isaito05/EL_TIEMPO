using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{

    public class T_RGU_USUARIO
    {
        [Key]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Identificacion :")]
        public int RGU_IDENTIFICACION { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name ="Nombres :")]
        public string RGU_NOMBRES { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Apellidos :")]
        public string RGU_APELLIDOS { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [StringLength(9, MinimumLength = 8, ErrorMessage = "Caracteres maximo 9 minimo 8")]
        [Display(Name = "Genero :")]
        public string RGU_GENERO { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Fecha de nacimientoS :")]
        public DateTime RGU_FCH_NACIMIENTO { get; set; }
        
    }
}
