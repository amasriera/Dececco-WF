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
    
    public partial class cop_Resumen_cuenta_Find_Result
    {
        public int Id_resumen_cuenta { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
        public string Detalle { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<int> Id_empresa { get; set; }
        public Nullable<int> Id_banco { get; set; }
        public Nullable<int> Id_cuenta { get; set; }
    }
}
