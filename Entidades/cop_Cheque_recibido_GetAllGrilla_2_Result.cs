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
    
    public partial class cop_Cheque_recibido_GetAllGrilla_2_Result
    {
        public int id_cheque_recibido { get; set; }
        public Nullable<bool> control { get; set; }
        public Nullable<bool> pago_tercero { get; set; }
        public string numero_cheque { get; set; }
        public string apellido_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string nombre_banco { get; set; }
        public string detalle { get; set; }
        public Nullable<System.DateTime> fecha_recibido { get; set; }
        public Nullable<System.DateTime> fecha_acreditacion { get; set; }
        public Nullable<decimal> importe { get; set; }
        public Nullable<decimal> iva { get; set; }
        public string nombre_proveedor { get; set; }
        public Nullable<bool> anulado { get; set; }
    }
}
