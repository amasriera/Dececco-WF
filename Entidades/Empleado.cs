//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Empleado
    {
        public int id_empleado { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string dni { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string mail { get; set; }
        public Nullable<decimal> valor_hora { get; set; }
        public Nullable<int> id_tipo_empleado { get; set; }
    }
}
