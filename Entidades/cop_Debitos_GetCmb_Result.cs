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
    
    public partial class cop_Debitos_GetCmb_Result
    {
        public int id_debito { get; set; }
        public string detalle { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public string comprobante { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<int> id_cuenta { get; set; }
        public Nullable<int> id_banco { get; set; }
        public Nullable<int> id_empresa { get; set; }
        public Nullable<System.DateTime> periodo { get; set; }
        public Nullable<bool> control { get; set; }
        public Nullable<decimal> iva { get; set; }
    }
}
