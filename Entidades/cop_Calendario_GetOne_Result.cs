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
    
    public partial class cop_Calendario_GetOne_Result
    {
        public int Id_calendario { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<int> Id_dia { get; set; }
        public Nullable<bool> dia_laboral { get; set; }
        public Nullable<System.DateTime> hora_inicio { get; set; }
        public Nullable<System.DateTime> hora_fin { get; set; }
        public bool feriado { get; set; }
    }
}
