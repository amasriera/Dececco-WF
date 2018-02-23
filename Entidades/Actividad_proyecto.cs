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
    
    public partial class Actividad_proyecto 
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividad_proyecto()
        {
            this.Programacion_Actividad = new HashSet<Programacion_Actividad>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividad_proyecto(int id_proyecto, int id_actividad, DateTime fecha_inicio, DateTime fecha_fin_previsto, DateTime fecha_fin_real, int cantidad_hora, string objetivo, int prioridad, int complejidad, int avance, string observacion, int orden, int id_controlador_1, int id_controlador_2, int nro, int id_cliente, int id_subproyecto, int horas, int id_estado_proyecto, int porcentaje_avance, DateTime fecha_inicio_real, bool asignada, int id_cadista, int id_prioridad, int id_control, int id_proveedor, bool forzada_fecha_fin, bool forzada_fecha_inicio, bool no_conformidad, string motivo_no_conformidad, bool asignable)
        {
            this.id_proyecto = id_proyecto;
            this.id_actividad = id_actividad;
            this.fecha_inicio = fecha_inicio;
            this.fecha_fin_previsto = fecha_fin_previsto;
            this.fecha_fin_real = fecha_fin_real;
            this.cantidad_hora = cantidad_hora;
            this.objetivo = objetivo;
            this.prioridad = prioridad;
            this.complejidad = complejidad;
            this.avance = avance;
            this.observacion = observacion;
            this.orden = orden;
            this.id_controlador_1 = id_controlador_1;
            this.id_controlador_2 = id_controlador_2;
            this.nro = nro;
            this.id_cliente = id_cliente;
            this.id_subproyecto = id_subproyecto;
            this.horas = horas;
            this.id_estado_proyecto = id_estado_proyecto;
            this.porcentaje_avance = porcentaje_avance;
            this.fecha_inicio_real = fecha_inicio_real;
            this.asignada = asignada;
            this.id_cadista = id_cadista;
            this.id_prioridad = id_prioridad;
            this.id_control = id_control;
            this.id_proveedor = id_proveedor;
            this.forzada_fecha_fin = forzada_fecha_fin;
            this.forzada_fecha_inicio = forzada_fecha_inicio;
            this.no_conformidad = no_conformidad;
            this.motivo_no_conformidad = motivo_no_conformidad;
            this.asignable = asignable;
            this.Programacion_Actividad = new HashSet<Programacion_Actividad>();
        }

        public int id_actividad_proyecto { get; set; }
        public Nullable<int> id_proyecto { get; set; }
        public Nullable<int> id_actividad { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin_previsto { get; set; }
        public Nullable<System.DateTime> fecha_fin_real { get; set; }
        public Nullable<decimal> cantidad_hora { get; set; }
        public string objetivo { get; set; }
        public Nullable<decimal> prioridad { get; set; }
        public Nullable<decimal> complejidad { get; set; }
        public Nullable<decimal> avance { get; set; }
        public string observacion { get; set; }
        public Nullable<decimal> orden { get; set; }
        public Nullable<int> id_controlador_1 { get; set; }
        public Nullable<int> id_controlador_2 { get; set; }
        public Nullable<int> nro { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> id_subproyecto { get; set; }
        public Nullable<int> horas { get; set; }
        public Nullable<int> id_estado_proyecto { get; set; }
        public Nullable<decimal> porcentaje_avance { get; set; }
        public Nullable<System.DateTime> fecha_inicio_real { get; set; }
        public Nullable<bool> asignada { get; set; }
        public Nullable<int> id_cadista { get; set; }
        public Nullable<int> id_prioridad { get; set; }
        public int id_control { get; set; }
        public Nullable<int> id_proveedor { get; set; }
        public bool forzada_fecha_fin { get; set; }
        public bool forzada_fecha_inicio { get; set; }
        public bool no_conformidad { get; set; }
        public string motivo_no_conformidad { get; set; }
        public bool asignable { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Programacion_Actividad> Programacion_Actividad { get; set; }
    }
}
