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
    
    public partial class Calendario_usuario
    {
        public int id_calendario_usuario { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public Nullable<int> id_calendario { get; set; }
        public Nullable<bool> trabaja { get; set; }
        public Nullable<System.DateTime> hora_inicio { get; set; }
        public Nullable<System.DateTime> hora_fin { get; set; }
        public string motivo { get; set; }
    }
}
