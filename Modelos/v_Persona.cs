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
    
    public partial class v_Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Nombre_Completo { get; set; }
        public string Documento { get; set; }
        public string Titulo { get; set; }
        public string Contacto { get; set; }
        public string Empresa { get; set; }
        public string Correo { get; set; }
        public string Comentarios { get; set; }
        public string Direccion { get; set; }
        public string Direccion_De_Envio { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Balance { get; set; }
        public Nullable<decimal> Limite_Credito { get; set; }
        public byte Id_Tipo_Persona { get; set; }
        public string Tipo_Persona { get; set; }
        public Nullable<int> Id_Persona { get; set; }
        public int Id_Estatus { get; set; }
        public string Estatus_Descripcion { get; set; }
    }
}
