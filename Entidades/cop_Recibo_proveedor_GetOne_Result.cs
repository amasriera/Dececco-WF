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
    
    public partial class cop_Recibo_proveedor_GetOne_Result
    {
        public int Id_recibo_proveedor { get; set; }
        public Nullable<int> Id_proveedor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Pago { get; set; }
        public string Detalle { get; set; }
        public string Numero_recibo { get; set; }
        public Nullable<decimal> Retencion_iva { get; set; }
        public Nullable<decimal> Ingreso_bruto { get; set; }
        public Nullable<decimal> Impuesto_ganancia { get; set; }
        public Nullable<decimal> Suss { get; set; }
    }
}
