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
    
    public partial class cop_Proyecto_Find_Result
    {
        public int Id_proyecto { get; set; }
        public string Descripcion { get; set; }
        public string Nombre_proyecto { get; set; }
        public Nullable<int> Id_cliente { get; set; }
        public Nullable<int> Id_proyecto_padre { get; set; }
        public Nullable<int> Id_proyect_manager { get; set; }
        public Nullable<System.DateTime> Fecha_inicio { get; set; }
        public Nullable<System.DateTime> Fecha_fin_prevista { get; set; }
        public Nullable<System.DateTime> Fecha_fin_real { get; set; }
        public string Orden { get; set; }
        public Nullable<int> Id_estado { get; set; }
        public Nullable<decimal> Total_hora { get; set; }
        public Nullable<decimal> Prioridad { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> Id_controlador_1 { get; set; }
        public Nullable<int> Id_controlador_2 { get; set; }
        public string Path { get; set; }
        public Nullable<bool> Archivado { get; set; }
        public Nullable<int> Indice { get; set; }
        public Nullable<int> Nro { get; set; }
        public int Id_piloto { get; set; }
    }
}
