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
    
    public partial class cop_Pago_cliente_GetCmb_Result
    {
        public int id_pago_cliente { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<decimal> pago { get; set; }
        public string detalle { get; set; }
        public Nullable<bool> efectivo { get; set; }
        public string numero_recibo { get; set; }
        public Nullable<decimal> retencion_iva { get; set; }
        public Nullable<decimal> ingreso_bruto { get; set; }
        public Nullable<decimal> impuesto_ganancia { get; set; }
        public Nullable<decimal> suss { get; set; }
        public string total_letra { get; set; }
        public string observacion { get; set; }
    }
}
