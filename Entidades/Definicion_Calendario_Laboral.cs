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
    
    public partial class Definicion_Calendario_Laboral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Definicion_Calendario_Laboral()
        {
            this.Detalle_Calendario_Laboral = new HashSet<Detalle_Calendario_Laboral>();
        }
    
        public int id_definicion_calendario_laboral { get; set; }
        public string nombre_definicion { get; set; }
        public System.DateTime fecha_desde { get; set; }
        public System.DateTime fecha_hasta { get; set; }
        public int id_calendario_laboral { get; set; }
    
        public virtual Calendario_Laboral Calendario_Laboral { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Calendario_Laboral> Detalle_Calendario_Laboral { get; set; }
    }
}
