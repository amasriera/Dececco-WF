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
    
    public partial class usp_SUBPROYECTOUpdate_Result
    {
        public int id_subproyecto { get; set; }
        public Nullable<int> id_proyecto { get; set; }
        public Nullable<int> id_tipo_subproyecto { get; set; }
        public Nullable<int> id_subproyecto_padre { get; set; }
        public string nombre { get; set; }
        public Nullable<System.DateTime> fecha_inicio_estimada { get; set; }
        public Nullable<System.DateTime> fecha_inicio_real { get; set; }
        public Nullable<System.DateTime> fecha_fin_estimada { get; set; }
        public Nullable<System.DateTime> fecha_fin_real { get; set; }
        public Nullable<int> id_prioridad { get; set; }
        public Nullable<int> horas_estimadas { get; set; }
        public Nullable<int> id_estado_proyecto { get; set; }
        public Nullable<int> id_hora_tipo_subproyecto { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> ot { get; set; }
        public Nullable<bool> genera_ot { get; set; }
        public Nullable<int> id_proyecto_viejo { get; set; }
        public Nullable<int> id_proyecto_padre_viejo { get; set; }
    }
}
