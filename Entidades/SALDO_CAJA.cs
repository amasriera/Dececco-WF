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
    
    public partial class SALDO_CAJA
    {
        public int id_saldo_banco { get; set; }
        public int id_empresa { get; set; }
        public System.DateTime fecha_saldo { get; set; }
        public Nullable<decimal> saldo { get; set; }
        public int id_cuenta { get; set; }
    }
}
