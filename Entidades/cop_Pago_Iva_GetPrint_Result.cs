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
    
    public partial class cop_Pago_Iva_GetPrint_Result
    {
        public int ID_PAGO_Iva { get; set; }
        public Nullable<System.DateTime> FECHA_PAGO_Iva { get; set; }
        public Nullable<decimal> PAGO_Iva { get; set; }
        public string NUMERO_RECIBO_PAGO_Iva { get; set; }
        public int ID_EMPRESA { get; set; }
        public int ID_Iva { get; set; }
        public Nullable<bool> EFECTIVO_Iva { get; set; }
        public string NUMERO_CHEQUE_Iva { get; set; }
        public Nullable<System.DateTime> FECHA_EMISION_CHEQUE_Iva { get; set; }
        public Nullable<System.DateTime> FECHA_PAGO_CHEQUE_Iva { get; set; }
        public string DETALLE_CHEQUE_Iva { get; set; }
        public string DETALLE_PAGO { get; set; }
    }
}