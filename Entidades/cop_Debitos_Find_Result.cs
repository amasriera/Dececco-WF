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
    
    public partial class cop_Debitos_Find_Result
    {
        public int Id_debito { get; set; }
        public string Detalle { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Comprobante { get; set; }
        public Nullable<decimal> Importe { get; set; }
        public Nullable<int> Id_cuenta { get; set; }
        public Nullable<int> Id_banco { get; set; }
        public Nullable<int> Id_empresa { get; set; }
        public Nullable<System.DateTime> Periodo { get; set; }
        public Nullable<bool> Control { get; set; }
        public Nullable<decimal> Iva { get; set; }
    }
}
