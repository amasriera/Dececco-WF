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
    
    public partial class CHEQUE_PROVEEDOR
    {
        public int id_cheque_proveedor { get; set; }
        public Nullable<int> id_recibo_proveedor { get; set; }
        public Nullable<int> id_cheque_librado { get; set; }
        public Nullable<bool> control { get; set; }
    }
}