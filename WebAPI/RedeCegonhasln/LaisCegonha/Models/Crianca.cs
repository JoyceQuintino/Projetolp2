using System;
using System.Collections.Generic;
using System.Text;

namespace laiscegonha.Models
{
    public partial class Crianca
    {
       
        public int Id { get; set; }
        public int Declaracao { get; set; }
        public decimal Peso { get; set; }
        public string Sexo { get; set; }
        public int IdMae { get; set; }
        public string Apgar1 { get; set; }
        public string Apgar5 { get; set; }

        public virtual Mae Mae { get; set; }
    }
}
