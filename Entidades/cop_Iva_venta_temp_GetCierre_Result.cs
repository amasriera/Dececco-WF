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
    
    public partial class cop_Iva_venta_temp_GetCierre_Result
    {
        public int Id_iva_venta_temp { get; set; }
        public string Numero { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Factura { get; set; }
        public string Nombre { get; set; }
        public string Cuit { get; set; }
        public Nullable<decimal> Imp_gravado { get; set; }
        public Nullable<decimal> Imp_exento { get; set; }
        public Nullable<decimal> Conc_no_grav { get; set; }
        public Nullable<decimal> Iva { get; set; }
        public Nullable<decimal> Iva_no_ins { get; set; }
        public Nullable<decimal> Totals { get; set; }
        public Nullable<decimal> Iva_ret { get; set; }
    }
}
