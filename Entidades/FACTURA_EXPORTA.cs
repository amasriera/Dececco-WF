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
    
    public partial class FACTURA_EXPORTA
    {
        public int id_factura { get; set; }
        public int id_cliente { get; set; }
        public string numero_factura { get; set; }
        public System.DateTime fecha_factura { get; set; }
        public string nro_orden { get; set; }
        public string zona { get; set; }
        public string cuenta { get; set; }
        public string forma_pago { get; set; }
        public Nullable<bool> anulada { get; set; }
        public Nullable<decimal> subtotal_factura { get; set; }
        public string tipo_factura { get; set; }
        public Nullable<decimal> total_factura { get; set; }
        public string total_letra { get; set; }
        public string movimiento { get; set; }
        public string origen { get; set; }
        public string via_transporte { get; set; }
        public string puerto_embarque { get; set; }
        public string puerto_desembarque { get; set; }
        public string destino { get; set; }
        public string cantidad_tipo_cajas { get; set; }
        public string peso_neto { get; set; }
        public string peso_bruto { get; set; }
    }
}
