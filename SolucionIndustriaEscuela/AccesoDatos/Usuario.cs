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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Ventas = new HashSet<Venta>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public bool Habilitado { get; set; }
        public int RolId { get; set; }
    
        public virtual Rol Rol { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}