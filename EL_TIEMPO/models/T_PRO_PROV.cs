using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MI_TERRAZA.Models
{
    public class T_PRO_PROV
    {
		[Key]
		public int PROPROV_ID { get; set; }

		[Required(ErrorMessage = "Este campo es obligatorio")]
		[Display(Name = "ID del proveedor que Suministra el producto:")]
		[ForeignKey("T_PROVEEDOR")]
		public int PROPROV_PROV_ID { get; set; }
		public T_PROVEEDOR? T_PROVEEDOR { get; set; }

		[Required(ErrorMessage = "Este campo es obligatorio")]
		[Display(Name = "Nombre Del Producto Suministrado Por El Proveedor :")]
		public string PROPROV_NOMBRE { get; set; } = null!;

		[Required(ErrorMessage = "Este campo es obligatorio")]
		[Display(Name = "Cantidad Del Producto Suministrado Por El Proveedor : :")]
		public string PROPROV_CANTIDAD { get; set; } = null!;

		[Required(ErrorMessage = "Este campo es obligatorio")]
		[Display(Name = "Precio Del Producto Suministrado Por El Proveedor : :")]
		public decimal PROPROV_PRECIO_UNITARIO { get; set; }

		[Required(ErrorMessage = "Este campo es obligatorio")]
		[Display(Name = "Fecha Del Producto Suministrado Por El Proveedor : :")]
		public DateTime PROPROV_FCH_INGRESO { get; set; }

		[Required(ErrorMessage = "Este campo es obligatorio")]
		[Display(Name = "Total Del Producto Suministrado Por El Proveedor : :")]
		public decimal PROPROV_TOTAL { get; set; }
	}
}
