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
    
    public partial class Consulta_saldo_cliente
    {
        public int id_consulta_saldo_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public Nullable<decimal> saldo_anterior { get; set; }
        public Nullable<decimal> saldo_actual { get; set; }
        public Nullable<decimal> saldo_total { get; set; }
    }
}
