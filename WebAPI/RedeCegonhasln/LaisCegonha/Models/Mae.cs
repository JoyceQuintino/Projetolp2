using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Models
{
    public partial class Mae
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int QuantFilhosVivos { get; set; }
        public int QuantFilhosMortos { get; set; }
        public string Escolaridade { get; set; }
        public string EstadoCivil { get; set; }
        public string Cpf { get; set; }
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<Crianca> Crianca { get; set; }
        public virtual ICollection<Parto> Parto { get; set; }
        public virtual ICollection<MaeConsultaPreNatal> MaeConsultaPreNatal { get; set; }
    }
}
