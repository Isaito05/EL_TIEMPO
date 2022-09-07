using MI_TERRAZA.Models;
using Microsoft.EntityFrameworkCore;


namespace EL_TIEMPO
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)//contrusctor de la clase
        {

        }

        public DbSet<T_BODEGA>? T_BODEGA { get; set; }
        public DbSet<T_CLIENTE>? T_CLIENTE { get; set; }
        public DbSet<T_CORREO>? T_CORREO { get; set; }
        public DbSet<T_CORREO_PROV>? T_CORREO_PROV { get; set; }
        public DbSet<T_DIRECCION>? T_DIRECCION { get; set; }
        public DbSet<T_DIRECCION_PROV>? T_DIRECCION_PROV { get; set; }
        public DbSet<T_PAGO>? T_PAGO { get; set; }
        public DbSet<T_PED_PRO>? T_PED_PRO { get; set; }
        public DbSet<T_PEDIDO>? T_PEDIDO { get; set; }
        public DbSet<T_PRESTAMO>? T_PRESTAMO { get; set; }
        public DbSet<T_PRO_BOD>? T_PRO_BOD { get; set; }
        public DbSet<T_PRO_PROV>? T_PRO_PROV { get; set; }
        public DbSet<T_PRODUCTO>? T_PRODUCTO { get; set; }
        public DbSet<T_PROVEEDOR>? T_PROVEEDOR { get; set; }
        public DbSet<T_RGU_USUARIO>? T_RGU_USUARIO { get; set; }
        public DbSet<T_SUMINISTRA>? T_SUMINISTRA { get; set; }
        public DbSet<T_TELEFONO>? T_TELEFONO { get; set; }
        public DbSet<T_TELEFONO_PROV>? T_TELEFONO_PROV { get; set; }
        public DbSet<T_TRAB_PAGO>? T_TRAB_PAGO { get; set; }
        public DbSet<T_TRAB_PRES>? T_TRAB_PRES { get; set; }
        public DbSet<T_TRABAJADOR>? T_TRABAJADOR { get; set; }
    }
}
