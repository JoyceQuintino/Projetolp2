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
    
    public partial class ConsultaPreNatal
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConsultaPreNatal()
        {
            this.MaeConsultaPreNatal = new HashSet<MaeConsultaPreNatal>();
        }
    
        public int Id { get; set; }
        public int NumeroDeConsultas { get; set; }
        public string EstadoNutricional { get; set; }
        public string TipoParto { get; set; }
        public decimal PressaoArterial { get; set; }
        public string MovitacaoFetal { get; set; }
        public System.DateTime DataConsulta { get; set; }
        public decimal AlturaUterina { get; set; }
        public decimal BatimentoCadiacoFetal { get; set; }
        public string UsuariaDrogas { get; set; }
        public string Fumante { get; set; }
        public string UsuariaAlcool { get; set; }
        public string Diabetes { get; set; }
        public string Obsidade { get; set; }
        public string TempoGestacao { get; set; }
        public string Gravidez { get; set; }
        public string HoraConsulta { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaeConsultaPreNatal> MaeConsultaPreNatal { get; set; }
    }
}