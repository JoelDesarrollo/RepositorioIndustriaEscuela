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
    
    public partial class Insumo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public Nullable<decimal> Stock { get; set; }
        public bool Habilitado { get; set; }
        public string UnidadMedida { get; set; }
        public int ProductoId { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
