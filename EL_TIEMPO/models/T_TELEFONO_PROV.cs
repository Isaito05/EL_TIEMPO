using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_TELEFONO_PROV
    {
        [Key]
        public int TELPROV_ID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Numero de telefono invalido")]
        public int TELPROV_NUMERO { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string TELPROV_OPERADOR { get; set; } = null!;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int TELPROV_PROV_ID { get; set; }
    }
}
