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
    
    public partial class Cliente : Persona
    {
        public Cliente()
        {
            this.Compras = new HashSet<Venta>();
        }
    
        public bool Habilitado { get; set; }
    
        public virtual CuentaCorriente CuentaCorriente { get; set; }
        public virtual ICollection<Venta> Compras { get; set; }
    }
}
