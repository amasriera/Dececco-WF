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
    
    public partial class cop_Proyecto_GetCmb_2_Result
    {
        public int id_proyecto { get; set; }
        public string descripcion { get; set; }
        public string Nombre_proyecto { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> id_proyecto_padre { get; set; }
        public Nullable<int> id_proyect_manager { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin_prevista { get; set; }
        public Nullable<System.DateTime> fecha_fin_real { get; set; }
        public string orden { get; set; }
        public Nullable<int> id_estado { get; set; }
        public Nullable<decimal> total_hora { get; set; }
        public Nullable<decimal> prioridad { get; set; }
        public string observacion { get; set; }
        public Nullable<int> id_controlador_1 { get; set; }
        public Nullable<int> id_controlador_2 { get; set; }
        public string path { get; set; }
        public Nullable<bool> archivado { get; set; }
        public int id_piloto { get; set; }
    }
}
