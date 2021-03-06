//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producto
    {
        public Producto()
        {
            this.Insumos = new HashSet<Insumo>();
        }
    
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public string UnidadMedida { get; set; }
        public Nullable<decimal> Stock { get; set; }
        public bool Habilitado { get; set; }
    
        public virtual DetalleVenta DetalleVenta { get; set; }
        public virtual ICollection<Insumo> Insumos { get; set; }
    }
}
