//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RedeCegonha.Modelagem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Apgar5
    {
        public int Id { get; set; }
        public int FrequenciaCardiaca { get; set; }
        public int Respiracao { get; set; }
        public int TonusMuscular { get; set; }
        public int Reflexos { get; set; }
        public string CorDaPele { get; set; }
        public int IdMedico { get; set; }
    
        public virtual Medico Medico { get; set; }
        public virtual Crianca Crianca { get; set; }
    }
}
