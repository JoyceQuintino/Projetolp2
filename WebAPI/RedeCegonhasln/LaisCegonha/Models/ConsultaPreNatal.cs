using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Models
{
    public partial class ConsultaPreNatal
    {
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

        public virtual ICollection<MaeConsultaPreNatal> MaeConsultaPreNatal { get; set; }
    }
}
