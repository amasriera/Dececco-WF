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
    
    public partial class cop_Detalle_recurso_GetOneIngreso_Result
    {
        public int id_detalle_recurso { get; set; }
        public Nullable<int> id_actividad_proyecto { get; set; }
        public Nullable<int> id_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public Nullable<decimal> cantidad_hora { get; set; }
        public string motivo { get; set; }
        public Nullable<bool> realizada { get; set; }
        public bool forzada { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
    }
}