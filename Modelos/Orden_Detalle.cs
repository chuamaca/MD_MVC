//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orden_Detalle
    {
        public int Id { get; set; }
        public int Id_Orden { get; set; }
        public int Id_Producto { get; set; }
        public string Descripcion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Impuesto { get; set; }
        public decimal Monto { get; set; }
    
        public virtual Orden Orden { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
