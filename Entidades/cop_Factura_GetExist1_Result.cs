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
    
    public partial class cop_Factura_GetExist1_Result
    {
        public int Id_factura { get; set; }
        public int Id_cliente { get; set; }
        public string Numero_factura { get; set; }
        public System.DateTime Fecha_factura { get; set; }
        public Nullable<decimal> Iva_factura { get; set; }
        public Nullable<bool> Anulada { get; set; }
        public Nullable<decimal> Subtotal_factura { get; set; }
        public string Tipo_factura { get; set; }
        public Nullable<decimal> Total_iva { get; set; }
        public Nullable<decimal> Total_factura { get; set; }
        public string Total_letra { get; set; }
        public string Movimiento { get; set; }
        public Nullable<bool> Responsable_inscripto { get; set; }
        public Nullable<bool> Responsable_no_inscripto { get; set; }
        public Nullable<bool> Contado { get; set; }
        public Nullable<bool> Cuenta_corriente { get; set; }
        public string Numero_recibo { get; set; }
        public Nullable<decimal> Impuesto { get; set; }
        public Nullable<decimal> Iva_no_inscripto { get; set; }
        public string Condicion_pago { get; set; }
        public string Referencia { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> Retencion_iva { get; set; }
        public Nullable<bool> Archivada { get; set; }
        public Nullable<bool> Pago_parcial { get; set; }
        public Nullable<decimal> Saldo { get; set; }
    }
}
