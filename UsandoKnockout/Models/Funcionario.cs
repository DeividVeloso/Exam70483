//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UsandoKnockout.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Funcionario
    {
        public int funcionarioId { get; set; }
        public string nome { get; set; }
        public string titulo { get; set; }
        public System.DateTime nascimento { get; set; }
        public string estadocivil { get; set; }
        public string sexo { get; set; }
        public Nullable<System.DateTime> admissao { get; set; }
    }
}