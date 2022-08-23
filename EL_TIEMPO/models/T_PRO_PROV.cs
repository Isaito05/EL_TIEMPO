using System.ComponentModel.DataAnnotations;

namespace MI_TERRAZA.Models
{
    public class T_PRO_PROV
    {
		[Key]
		public int PROPROV_ID { get; set; } 
		public string PROPROV_NOMBRE { get; set; } = null!;
		public string PROPROV_CANTIDAD { get; set; } = null!;
		public decimal PROPROV_PRECIO_UNITARIO { get; set; } 
		public DateTime PROPROV_FCH_INGRESO { get; set; }
		public decimal PROPROV_TOTAL { get; set; }
	}
}
